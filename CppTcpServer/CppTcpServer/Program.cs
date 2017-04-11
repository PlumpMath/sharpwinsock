using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CppTcpServer
{
    class Program
    {
        static void Main(string[] args)
        {
            WinsockAccept();
        }

        [DllImport("WinsockTcpServer.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void WinsockAccept();
    }
}
