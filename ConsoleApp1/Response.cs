using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Response
    {
        private Byte[] data = null;

        private Response(String, Byte[] data)
        {


        }

        public static Response From(Request request)
        {

        }

        public void Post(NetworkStream stream)
        {
            stream.Write()
        }

    }
}
