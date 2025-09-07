using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ServerWCF;

namespace ServerWcfConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (var host = new ServiceHost(typeof(Service1))) // Replace with your service class
            {
                host.Open();
                Console.WriteLine("Service is running...");
                Console.ReadLine();
                host.Close();
            }

        }
    }
}
