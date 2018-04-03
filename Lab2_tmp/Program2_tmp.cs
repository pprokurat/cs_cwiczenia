using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;



namespace Lab2_tmp
{
    class Program2_tmp
    {
        static void Main(string[] args)
        {
            WebServer_tmp ws = new WebServer_tmp();
            ws.Run();
            Console.WriteLine("A simple webserver. Press a key to quit.");
            Console.ReadKey();
            //ws.Stop();

        }
    }
}
