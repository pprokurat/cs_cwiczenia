using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Lab2
{
    public class WebServer
    {
        private string port;
        private string path;

        public WebServer()
        {
            port = "8000";
            path = "E:/dokumenty_studia/zaawansowane_techniki_programowania_C#/ćwiczenia/cs_cwiczenia/Lab2/";
        }

        public WebServer(string port, string path)
        {
            this.port = port;
            this.path = path;
        }

        public void Run()
        {
                HttpListener listener = new HttpListener();
                listener.Prefixes.Add("http://localhost:" + port + "/");
                listener.Start();

            try
            {
                while (true)
                {
                    Console.WriteLine("Waiting...");
                    HttpListenerContext context = listener.GetContext();
                    Random rnd = new Random();
                    int fileNr = rnd.Next(1, 5);
                    string filePath = path + "dokument" + fileNr + ".html";
                    string msg = File.ReadAllText(filePath);
                    context.Response.ContentLength64 = Encoding.UTF8.GetByteCount(msg);
                    context.Response.StatusCode = (int)HttpStatusCode.OK;

                    using (Stream stream = context.Response.OutputStream)
                    {
                        using (StreamWriter writer = new StreamWriter(stream))
                        {
                            writer.Write(msg);
                        }
                    }

                    Console.WriteLine("msg sent " + context.Response.StatusCode);
                }
            }
            catch (WebException e)
            {
                Console.WriteLine(e.Status);
            }

        }

        //public void Stop()
        //{
        //    if (listener != null)
        //        listener.Stop();
        //}

    }
}
