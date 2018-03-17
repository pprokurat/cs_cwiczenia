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
           GenHTML kodHTML = new GenHTML(5,5);

            kodHTML.AddHTML();

            //kodHTML.WriteHTML();

            kodHTML.ToFile();
                      

            Console.ReadLine();
        }
    }
}
