using System.Collections.Generic;
using System.Xml;

namespace Satellaview server
{
    public interface IEventScriptEngine
    {
        void ExecuteScript(string script);
        void ExecuteCommand(EventCommand command);
        object GetVariable(string name);
        void SetVariable(string name, object value);
    }

    public class LuaScriptEngine : IEventScriptEngine
    {
        public void ExecuteScript(string script)
        {
            // Lua implementation would go here
        }
        
        public void ExecuteCommand(EventCommand command)
        {
            // Convert command to script and execute
        }
        
        public object GetVariable(string name)
        {
            return null; // Actual implementation would return variable
        }
        
        public void SetVariable(string name, object value)
        {
            // Set variable implementation
        }
    }

    public class NPCEvent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Point Position { get; set; }
        public List<EventCommand> Commands { get; set; }
        public string Script { get; set; }
        
        public NPCEvent()
        {
            Commands = new List<EventCommand>();
        }

        public string ToXml()
        {
            var xml = new StringBuilder();
            xml.AppendLine("<NPCEvent>");
            xml.AppendLine($"<Id>{Id}</Id>");
            xml.AppendLine($"<Name>{Name}</Name>");
            xml.AppendLine($"<X>{Position.X}</X>");
            xml.AppendLine($"<Y>{Position.Y}</Y>");
            
            xml.AppendLine("<Commands>");
            foreach (var cmd in Commands)
            {
                xml.AppendLine("<Command>");
                xml.AppendLine($"<Type>{cmd.Type}</Type>");
                foreach (var param in cmd.Parameters)
                {
                    xml.AppendLine($"<Parameter name='{param.Key}'>{param.Value}</Parameter>");
                }
                xml.AppendLine("</Command>");
            }
            xml.AppendLine("</Commands>");
            
            if (!string.IsNullOrEmpty(Script))
            {
                xml.AppendLine($"<Script><![CDATA[{Script}]]></Script>");
            }
            
            xml.AppendLine("</NPCEvent>");
            return xml.ToString();
        }

        public static NPCEvent FromXml(string xml)
        {
            var doc = new XmlDocument();
            doc.LoadXml(xml);
            
            var npcEvent = new NPCEvent();
            npcEvent.Id = int.Parse(doc.SelectSingleNode("//Id").InnerText);
            npcEvent.Name = doc.SelectSingleNode("//Name").InnerText;
            npcEvent.Position = new Point(
                int.Parse(doc.SelectSingleNode("//X").InnerText),
                int.Parse(doc.SelectSingleNode("//Y").InnerText));
            
            foreach (XmlNode cmdNode in doc.SelectNodes("//Command"))
            {
                var cmd = new EventCommand();
                cmd.Type = cmdNode.SelectSingleNode("Type").InnerText;
                
                foreach (XmlNode paramNode in cmdNode.SelectNodes("Parameter"))
                {
                    cmd.Parameters.Add(
                        paramNode.Attributes["name"].Value,
                        paramNode.InnerText);
                }
                
                npcEvent.Commands.Add(cmd);
            }
            
            var scriptNode = doc.SelectSingleNode("//Script");
            if (scriptNode != null)
            {
                npcEvent.Script = scriptNode.InnerText;
            }
            
            return npcEvent;
        }

        public class EventCommand
        {
            public string Type { get; set; }
            public Dictionary<string, object> Parameters { get; set; }
            
            public EventCommand()
            {
                Parameters = new Dictionary<string, object>();
            }
        }

        public void LinkToBuildingAnimation(int buildingId)
        {
            var anim = EventPlazaEditor.animationController.BuildingAnimations
                .FirstOrDefault(a => a.BuildingId == buildingId);
            
            if (anim != null)
            {
                Commands.Add(new EventCommand
                {
                    Type = "PlayBuildingAnimation",
                    Parameters = 
                    {
                        { "buildingId", buildingId },
                        { "loop", false }
                    }
                });
            }
        }
    }
}
