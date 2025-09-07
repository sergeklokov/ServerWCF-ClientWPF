using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchWcfClient
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Launch WCF Test Client with working directory
            var startInfo = new ProcessStartInfo
            {
                //FileName = @"C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\WcfTestClient.exe",
                FileName = @"C:\Program Files\Microsoft Visual Studio\2022\Professional\Common7\IDE\WcfTestClient.exe",
                WorkingDirectory = @"C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\",
                UseShellExecute = true // Ensures proper UI launch
            };

            try
            {
                Process.Start(startInfo);
                Console.WriteLine("WCF Test Client launched. Add the service manually: http://localhost:8733/Design_Time_Addresses/ServerWCF/Service1/");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to launch WCF Test Client: " + ex.Message);
            }

            Console.ReadLine();

        }
    }
}
