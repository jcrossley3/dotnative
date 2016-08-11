using System;
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
            jvmParams.Add("-Djava.class.path", "/home/jim/apps/dotnet/native/narayana-jta-5.3.2.Final.jar:/home/jim/apps/dotnet/native/jta-1.1.jar:/home/jim/apps/dotnet/native/jboss-logging-3.2.1.Final.jar");
            Java.LoadVM(jvmParams, false);

            IntPtr tm = Java.CallStaticMethod<IntPtr>("Lcom/arjuna/ats/jta/TransactionManager;", "transactionManager", "()Ljavax/transaction/TransactionManager;", new List<object>());
            string name = Java.CallMethod<string>("Ljavax/transaction/TransactionManager;", tm, "toString", "()Ljava/lang/String;", new List<object>());
            Console.WriteLine("tm=" + name);
            // Java.CallVoidMethod("begin", "()V", new List<object>());
            // name = Java.CallMethod<string>("toString", "()Ljava/lang/String;", new List<object>());
            // Console.WriteLine("tm=" + name);
        }
    }
}
