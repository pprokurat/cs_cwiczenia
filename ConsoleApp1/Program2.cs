using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting server on port 8000...");
            HTTPServer server = new HTTPServer(8000);
            server.Start();

        }
    }
}
