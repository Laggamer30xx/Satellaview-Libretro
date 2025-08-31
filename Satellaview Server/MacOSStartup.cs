using System;
using System.Runtime.InteropServices;

namespace Satellaview_server
{
    public static class MacOSStartup
    {
        [DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
        private static extern void CFBundleGetMainBundle();

        public static void ValidateArchitecture()
        {
            if (RuntimeInformation.ProcessArchitecture != Architecture.X64)
            {
                throw new PlatformNotSupportedException(
                    "This application requires 64-bit mode on macOS");
            }
        }

        public static void Initialize()
        {
            ValidateArchitecture();

            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                // Force 64-bit mode
                Environment.SetEnvironmentVariable("DYLD_FORCE_64_BIT", "1");
                
                // Initialize CoreFoundation
                try { CFBundleGetMainBundle(); }
                catch { /* Silently handle missing Carbon */ }
            }
        }
    }
}
