using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class GenHTML
    {
        private int wysokosc;
        private int szerokosc;
        StringBuilder builder = new StringBuilder();

        public GenHTML(int wysokosc, int szerokosc)
        {
            this.wysokosc = wysokosc;
            this.szerokosc = szerokosc;
        }

        public void AddHTML()
        {
            
            builder.AppendLine("<!doctype html>");
            builder.AppendLine("<html>");
            builder.AppendLine("<head>");
            builder.AppendLine("<meta charset='UTF-8'>");
            builder.AppendLine("<title>Lab1</title>");
            builder.AppendLine("</head>");
            builder.AppendLine("<body>");
            builder.AppendLine("<h1>Hello world</h1>");
            builder.AppendLine("<table>");
            for (int i = 1; i <= wysokosc; i++)
            {
                builder.AppendLine("<tr>");
                for (int j = 1; j <= szerokosc; j++)
                {
                    builder.AppendLine("<td>["+i+","+j+"]</td>");
                }
                builder.AppendLine("</tr>");
            }
            builder.AppendLine("</table>");
            builder.AppendLine("</body>");
            builder.AppendLine("</html>");



            
        }

        public void WriteHTML()
        {
            Console.WriteLine(builder);
        }

        public void ToFile()
        {
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(@"e:\dokumenty_studia\zaawansowane_techniki_programowania_c#\ćwiczenia\cs_cwiczenia\dokument.html"))
            {
                file.WriteLine(builder);
            }
        }
        
    }
}
