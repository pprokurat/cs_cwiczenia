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
        public int port;
        public string path;
        private Boolean running;

        public WebServer()
        {
            port = 8000;
            path = "E:/dokumenty_studia/zaawansowane_techniki_programowania_C#/ćwiczenia/cs_cwiczenia/Lab2";
        }

        public WebServer(int port, string path)
        {
            this.port = port;
            this.path = path;
        }

        public void Run()
        {
            try
            {


            IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new TcpListener(ipAddress, port);
            listener.Start();
                running = true;

                while (running == true)
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
            }
            catch (WebException e)
            {
                Console.WriteLine(e.Status);
            }

        }

        public void Stop()
        {
            running = false;
        }

    }
}
