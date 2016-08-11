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
            jvmParams.Add("-Djava.class.path", "/home/jim/apps/dotnet/native/narayana-jta-5.3.2.Final.jar:/home/jim/apps/dotnet/native/jta-1.1.jar:/home/jim/apps/dotnet/native/jboss-logging-3.2.1.Final.jar");
            JavaNativeInterface Java = new JavaNativeInterface();

            Java.LoadVM(jvmParams, false);
            IntPtr tm = Java.CallStaticMethod<IntPtr>("Lcom/arjuna/ats/jta/TransactionManager;", "transactionManager", "()Ljavax/transaction/TransactionManager;", new List<object>());
            Console.WriteLine("tm=" + tm);
        }
    }
}
