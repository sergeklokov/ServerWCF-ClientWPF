using System;
using System.ServiceModel;

namespace ServerWCF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(Service1)))
            {
                host.Open();
                Console.WriteLine("Service started. Press Enter to exit...");
                Console.ReadLine();
                host.Close();
            }
        }
    }
}