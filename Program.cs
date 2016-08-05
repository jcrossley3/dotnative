using System;
using System.Runtime.InteropServices;

namespace ConsoleApplication
{
    public class Program
    {
        [DllImport("libc.so.6")]
        private static extern int getpid();

        public static void Main(string[] args)
        {
            int pid = getpid();
            Console.WriteLine("pid=" + pid);
        }
    }
}
