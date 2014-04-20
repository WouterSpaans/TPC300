using System;
using System.Runtime.InteropServices;

namespace TPC300
{
    internal static class Wrapper
    {
        // http://msdn.microsoft.com/en-us/library/26thfadc.aspx
        [DllImport("TPC300A.dll")]
        public static extern IntPtr Send(byte type, byte code, byte onoff);

        [DllImport("TPC300A.dll")]
        public static extern IntPtr Scene(byte number);
    }
}