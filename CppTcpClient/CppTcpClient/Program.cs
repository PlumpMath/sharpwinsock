using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CppTcpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string addr = "127.0.0.1";
            WinsockConnect(addr, addr.Length);
            //unsafe
            //{
            //    fixed (char* p = addr)
            //    {
            //        Console.WriteLine("The address stored in p: {0:X2}", (int)p);
            //        WinsockConnect(p);
            //    }
            //}
        }

        [DllImport("WinsockTcpClient.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void WinsockConnect(string addr, int size);
    }
}
