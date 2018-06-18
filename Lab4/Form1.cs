using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Point current = new Point();
        public Point old = new Point();
        int firstRect, secondRect;
        public Graphics g;
        public Pen pen = new Pen(Color.Black, 5);
        public Color paintcolor = Color.Black;
        bool draw;


        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
        }           

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            


        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                if (listBox1.SelectedIndex == 0 && e.Button == MouseButtons.Left)
                {
                    current = e.Location;

                    g.DrawLine(pen, old, current);

                    old = current;
                }
                else if (listBox1.SelectedIndex == 1)
                {
                    if (e.X >= firstRect && e.Y >= secondRect)
                        g.FillRectangle(new SolidBrush(paintcolor), firstRect, secondRect, e.X - firstRect, e.Y - secondRect);
                }
            }            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location;

            firstRect = e.X;
            secondRect = e.Y;

            draw = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == 0)
            {
                pen = new Pen(Color.Black, 5);
                paintcolor = Color.Black;
            }
            else if (listBox2.SelectedIndex == 1)
            {
                pen = new Pen(Color.Red, 5);
                paintcolor = Color.Red;
            }
            else if (listBox2.SelectedIndex == 2)
            {
                pen = new Pen(Color.Blue, 5);
                paintcolor = Color.Blue;
            }
            else if (listBox2.SelectedIndex == 3)
            {
                pen = new Pen(Color.Green, 5);
                paintcolor = Color.Green;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
