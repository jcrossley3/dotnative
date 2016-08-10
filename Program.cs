using System;
using System.Collections.Generic;
using JNI;


namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> jvmParams = new Dictionary<string, string>();
            JavaNativeInterface Java = new JavaNativeInterface();

            Java.LoadVM(jvmParams, false);
            Java.InstantiateJavaObject("Ljava/util/Random;");
            int x = Java.CallMethod<int>("nextInt", "()I", new List<object>());
            Console.WriteLine("x=" + x);
        }
    }
}
