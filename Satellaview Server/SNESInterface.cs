using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Satellaview_server
{
    public class SNESInterface : IDisposable
    {
        // Native DLL imports for hardware access
        [DllImport("sneshw.dll")]
        private static extern IntPtr snes_init();
        
        [DllImport("sneshw.dll")]
        private static extern void snes_free(IntPtr handle);
        
        [DllImport("sneshw.dll")]
        private static extern IntPtr snes_get_memory_ptr(IntPtr handle);
        
        [DllImport("sneshw.dll")]
        private static extern void snes_set_button(IntPtr handle, int button, int state);

        [DllImport("sneshw.dll")]
        private static extern int snes_get_button(IntPtr handle, int button);
        
        [DllImport("sneshw.dll")]
        private static extern void snes_wait_vblank(IntPtr handle);

        [DllImport("sneshw.dll")]
        private static extern void snes_delay_cycles(IntPtr handle, int cycles);
        
        private IntPtr _handle;
        
        public enum SNESButton {
            A, B, X, Y, L, R, Select, Start, Up, Down, Left, Right
        }
        
        public async Task InitializeAsync(CancellationToken ct = default)
        {
            await Task.Run(() => 
            {
                _handle = snes_init();
                if (_handle == IntPtr.Zero || ct.IsCancellationRequested)
                {
                    ct.ThrowIfCancellationRequested();
                    throw new Exception("SNES initialization failed");
                }
            }, ct);
        }
        
        public void Dispose()
        {
            if (_handle != IntPtr.Zero)
            {
                snes_free(_handle);
                _handle = IntPtr.Zero;
            }
        }
        
        public unsafe byte ReadByte(uint address)
        {
            if (address > 0xFFFFFF)
                throw new ArgumentOutOfRangeException(nameof(address));
                
            byte* ptr = (byte*)snes_get_memory_ptr(_handle);
            return ptr[address];
        }

        public unsafe void WriteByte(uint address, byte value)
        {
            if (address > 0xFFFFFF)
                throw new ArgumentOutOfRangeException(nameof(address));
                
            byte* ptr = (byte*)snes_get_memory_ptr(_handle);
            ptr[address] = value;
        }
        
        public async Task<byte> ReadByteAsync(uint address, CancellationToken ct = default)
        {
            if (address > 0xFFFFFF) throw new ArgumentOutOfRangeException(nameof(address));
            
            return await Task.Run(() => 
            {
                if (ct.IsCancellationRequested) ct.ThrowIfCancellationRequested();
                unsafe 
                {
                    byte* ptr = (byte*)snes_get_memory_ptr(_handle);
                    return ptr[address];
                }
            }, ct).ConfigureAwait(false);
        }

        public async Task WriteByteAsync(uint address, byte value, CancellationToken ct = default)
        {
            if (address > 0xFFFFFF) throw new ArgumentOutOfRangeException(nameof(address));
            
            await Task.Run(() => 
            {
                if (ct.IsCancellationRequested) ct.ThrowIfCancellationRequested();
                unsafe
                {
                    byte* ptr = (byte*)snes_get_memory_ptr(_handle);
                    ptr[address] = value;
                }
            }, ct).ConfigureAwait(false);
        }
        
        public void SetButtonState(SNESButton button, bool pressed)
        {
            snes_set_button(_handle, (int)button, pressed ? 1 : 0);
        }

        public bool GetButtonState(SNESButton button)
        {
            return snes_get_button(_handle, (int)button) != 0;
        }
        
        public async Task<bool> GetButtonStateAsync(SNESButton button, CancellationToken ct = default)
        {
            return await Task.Run(() => 
            {
                if (ct.IsCancellationRequested) ct.ThrowIfCancellationRequested();
                return GetButtonState(button);
            }, ct);
        }
        
        public void WaitForVBlank()
        {
            snes_wait_vblank(_handle);
        }

        public void DelayCycles(int cycles)
        {
            snes_delay_cycles(_handle, cycles);
        }
    }
}
