using System.Collections.Generic;

namespace Satellaview_server
{
    public class EventCommand
    {
        public string Type { get; set; }
        public Dictionary<string, object> Parameters { get; set; }
    }
}
