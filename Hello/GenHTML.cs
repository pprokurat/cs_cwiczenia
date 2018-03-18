using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class GenHTML
    {
        private int width;
        private int height;
        private string headerText;
        private string footerText; 
        StringBuilder builder = new StringBuilder();

        public GenHTML()
        {
            width = 5;
            height = 0;
        }

        public GenHTML(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void AddHeaderText(string headerText)
        {
            this.headerText = headerText;
        }

        public void AddFooterText(string footerText)
        {
            this.footerText = footerText;
        }

        public void AddRow()
        {
            this.height = this.height+1;
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
            builder.AppendLine("<table>");
            builder.AppendLine("<thead><tr>");
            builder.AppendLine("<th colspan='" + width + "'>" + headerText + "</th>");
            builder.AppendLine("</tr></thead>");
            builder.AppendLine("<tbody>");
            for (int i = 1; i <= height; i++)
            {
                builder.AppendLine("<tr>");
                for (int j = 1; j <= width; j++)
                {
                    builder.AppendLine("<td>["+i+","+j+"]</td>");
                }
                builder.AppendLine("</tr>");
            }
            builder.AppendLine("</tbody>");
            builder.AppendLine("<tfoot><tr>");
            builder.AppendLine("<td colspan='" + width + "'>" + footerText + "</td>");
            builder.AppendLine("</tr></tfoot>");
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
