using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private int portNumber;
        private string folderPath;
        WebServer ws = new WebServer();

        public Form1()
        {
            InitializeComponent();
        }

        

        public void PortNr_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (PortNr.Text != null)
                {
                    int x = Int32.Parse(PortNr.Text);
                    portNumber = x;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void FolderPath_TextChanged(object sender, EventArgs e)
        {
            folderPath = FolderPath.Text;
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            if(PortNr.Text != "")
            {
                ws.port = portNumber;                
            }

            if (FolderPath.Text != "")
            {
                ws.path = folderPath;
            }
            
            ws.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            ws.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ws.Stop();
        }
    }
}
