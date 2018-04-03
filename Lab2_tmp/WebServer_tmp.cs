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
    public class WebServer_tmp
    {
        private int port;
        private string path;

        public WebServer_tmp()
        {
            port = 8000;
            path = "E:/dokumenty_studia/zaawansowane_techniki_programowania_C#/ćwiczenia/cs_cwiczenia/Lab2_tmp";
        }

        public WebServer_tmp(int port, string path)
        {
            this.port = port;
            this.path = path;
        }
        
        public void Run()
        {
            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new TcpListener(ipAddress, port);
            listener.Start();

            while(true)
            {
                Console.WriteLine("Waiting for connection...");
                TcpClient client = listener.AcceptTcpClient();
                StreamReader sr = new StreamReader(client.GetStream());
                StreamWriter sw = new StreamWriter(client.GetStream());
                try
                {
                    //client request
                    string request = sr.ReadLine();
                    Console.WriteLine(request);
                    string[] tokens = request.Split(' ');
                    string page = tokens[1];
                    if (page == "/")
                    {
                        page = "/index.html";
                    }

                    //find the file
                    StreamReader file = new StreamReader(path + page);
                    sw.WriteLine("HTTP/1.1 200 OK\n");

                    //send the file
                    string data = file.ReadLine();
                    while (data != null)
                    {
                        sw.WriteLine(data);
                        sw.Flush();
                        data = file.ReadLine();
                    }

                }
                catch (Exception e)
                {
                    //error
                    sw.WriteLine("HTTP/1.1 404 OK\n");
                    sw.WriteLine("<h1>Error 404. Page not found.</h1>");


                    Console.WriteLine(e);
                }
                client.Close();
            }

            //try
            //{
                
            //    Console.WriteLine("Waiting...");
            //    HttpListenerContext context = listener.GetContext();
            //    Random rnd = new Random();
            //    int fileNr = rnd.Next(1, 5);
            //    string filePath = path + "dokument" + fileNr + ".html";
            //    string msg = File.ReadAllText(filePath);
            //    context.Response.ContentLength64 = Encoding.UTF8.GetByteCount(msg);
            //    context.Response.StatusCode = (int)HttpStatusCode.OK;

            //    using (Stream stream = context.Response.OutputStream)
            //    {
            //        using (StreamWriter writer = new StreamWriter(stream))
            //        {
            //            writer.Write(msg);                        
            //        }
            //    }

            //    Console.WriteLine("msg sent "+context.Response.StatusCode);
                
            //}              
            //catch (WebException e)
            //{
            //    Console.WriteLine(e.Status);
            //}

        }

        //public void Stop()
        //{

        //    if (listener != null)
        //        listener.Stop();
        //}

    }
}
