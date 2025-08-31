using System;
using System.Runtime.InteropServices;

namespace Satellaview server
{
    public static class LinuxStartup
    {
        public static void Initialize()
        {
#if LINUX
            // Linux-specific initialization
            Console.WriteLine("Linux mode initialized");
#endif
        }
    }
}
