using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
           GenHTML docHTML = new GenHTML();

            docHTML.AddHeaderText("Hello World!");

            docHTML.AddFooterText("Witaj świecie!");

            docHTML.AddRow();

            docHTML.AddHTML();

            //docHTML.WriteHTML();

            docHTML.ToFile();
                      

            Console.ReadLine();
        }
    }
}
