using System;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Net.WebSockets;
using System.Text;
using System.Xml;

namespace Satellaview server
{
    public enum TransportProtocol
    {
        TCP,
        WebSocket
    }

    public class NetworkManager
    {
        private TcpListener tcpListener;
        private TcpClient tcpClient;
        private WebSocket webSocket;
        private bool isRunning;
        
        public event Action<byte[]> OnDataReceived;
        public event Action OnConnected;
        
        public async Task StartServer(int port, TransportProtocol protocol)
        {
            isRunning = true;
            
            if (protocol == TransportProtocol.TCP)
            {
                tcpListener = new TcpListener(System.Net.IPAddress.Any, port);
                tcpListener.Start();
                
                while (isRunning)
                {
                    var client = await tcpListener.AcceptTcpClientAsync();
                    tcpClient = client;
                    _ = HandleClientAsync(client);
                }
            }
            else if (protocol == TransportProtocol.WebSocket)
            {
                _ = StartWebSocketServer(port);
            }
        }
        
        private async Task HandleClientAsync(TcpClient client)
        {
            try
            {
                OnConnected?.Invoke();
                
                var stream = client.GetStream();
                var buffer = new byte[4096];
                
                while (isRunning)
                {
                    // Read message length (4 bytes)
                    await stream.ReadAsync(buffer, 0, 4);
                    int length = BitConverter.ToInt32(buffer, 0);
                    
                    // Read message payload
                    var message = new byte[length];
                    await stream.ReadAsync(message, 0, length);
                    
                    OnDataReceived?.Invoke(message);
                }
            }
            catch {}
        }
        
        private async Task StartWebSocketServer(int port)
        {
            var httpListener = new System.Net.HttpListener();
            httpListener.Prefixes.Add($"http://*:{port}/");
            httpListener.Start();
            
            while (isRunning)
            {
                var context = await httpListener.GetContextAsync();
                if (context.Request.IsWebSocketRequest)
                {
                    webSocket = (await context.AcceptWebSocketAsync(null)).WebSocket;
                    _ = HandleWebSocketAsync();
                }
            }
        }
        
        private async Task HandleWebSocketAsync()
        {
            var buffer = new byte[4096];
            
            while (webSocket.State == WebSocketState.Open)
            {
                var result = await webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                
                if (result.MessageType == WebSocketMessageType.Binary)
                {
                    OnDataReceived?.Invoke(buffer[..result.Count]);
                }
            }
        }
        
        public async Task SyncEventData(NPCEvent npcEvent)
        {
            var eventData = npcEvent.ToXml();
            var message = new byte[5 + Encoding.UTF8.GetByteCount(eventData)];
            
            // Message type (1 = EventData)
            message[0] = 1;
            
            // Length (4 bytes)
            var lengthBytes = BitConverter.GetBytes(eventData.Length);
            Array.Copy(lengthBytes, 0, message, 1, 4);
            
            // Payload
            var dataBytes = Encoding.UTF8.GetBytes(eventData);
            Array.Copy(dataBytes, 0, message, 5, dataBytes.Length);
            
            if (webSocket?.State == WebSocketState.Open)
            {
                await webSocket.SendAsync(new ArraySegment<byte>(message), 
                    WebSocketMessageType.Binary, true, CancellationToken.None);
            }
            else if (tcpClient?.Connected == true)
            {
                await tcpClient.GetStream().WriteAsync(message, 0, message.Length);
            }
        }

        public async Task SyncAudioData(byte[] audioBytes)
        {
            var message = new byte[5 + audioBytes.Length];
            
            // Message type (2 = AudioData)
            message[0] = 2;
            
            // Length (4 bytes)
            var lengthBytes = BitConverter.GetBytes(audioBytes.Length);
            Array.Copy(lengthBytes, 0, message, 1, 4);
            
            // Payload
            Array.Copy(audioBytes, 0, message, 5, audioBytes.Length);
            
            if (webSocket?.State == WebSocketState.Open)
            {
                await webSocket.SendAsync(new ArraySegment<byte>(message), 
                    WebSocketMessageType.Binary, true, CancellationToken.None);
            }
            else if (tcpClient?.Connected == true)
            {
                await tcpClient.GetStream().WriteAsync(message, 0, message.Length);
            }
        }
        
        public void StopServer()
        {
            isRunning = false;
            tcpListener?.Stop();
        }
    }
}
