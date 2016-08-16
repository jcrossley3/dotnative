using System;
using System.IO;
using System.Collections.Generic;
using JNI;


namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            JavaNativeInterface Java = new JavaNativeInterface();
            Dictionary<string, string> jvmParams = new Dictionary<string, string>();
            jvmParams.Add("-Djava.class.path", string.Join(":", Directory.GetFiles("lib")));
            Java.LoadVM(jvmParams, false);

            IntPtr tm = Java.CallStaticMethod<IntPtr>("Lcom/arjuna/ats/jta/TransactionManager;", "transactionManager", "()Ljavax/transaction/TransactionManager;", new List<object>());
            string name = Java.CallMethod<string>("Ljavax/transaction/TransactionManager;", tm, "toString", "()Ljava/lang/String;", new List<object>());
            Console.WriteLine("tm=" + name);
            Java.CallVoidMethod("begin", "()V", new List<object>());
            name = Java.CallMethod<string>("toString", "()Ljava/lang/String;", new List<object>());
            Console.WriteLine("tm=" + name);
        }
    }
}
