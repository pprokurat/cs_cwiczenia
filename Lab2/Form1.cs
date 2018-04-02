using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private string portNumber;
        private string folderPath;
        //WebServer ws = null;

        public Form1()
        {
            InitializeComponent();
        }

        public void PortNr_TextChanged(object sender, EventArgs e)
        {
            portNumber = PortNr.Text;
        }

        private void FolderPath_TextChanged(object sender, EventArgs e)
        {
            folderPath = FolderPath.Text;
        }
        private void RunButton_Click(object sender, EventArgs e)
        {
            if(portNumber == "" || folderPath == "")
            {
                WebServer ws = new WebServer();
                ws.Run();
            }
            else
            {
                WebServer ws = new WebServer(portNumber,folderPath);
                ws.Run();
            }
            
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            //if (ws != null)
            //    ws.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
