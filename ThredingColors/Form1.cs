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
using System.Reflection;

namespace ThredingColors
{
    public partial class Form1 : Form
    {
        Random rdm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdm = new Random();
        }
        private void btnBlue_Click(object sender, EventArgs e)
        {
            var thread = new Thread(() => ThreadStart("Blue"));
            thread.Start();
        }
        
        private void btnRed_Click(object sender, EventArgs e)
        {
            var thread = new Thread(() => ThreadStart("Red"));
            thread.Start();
        }

        private void btnPink_Click(object sender, EventArgs e)
        {
            var thread = new Thread(() => ThreadStart("HotPink"));
            thread.Start();
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            var thread = new Thread(() => ThreadStart("Green"));
            thread.Start();
        }

        public void ThreadStart(string color)
        {
            for (int i = 0; i < 200; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Color.FromName(color), 4), new Rectangle(rdm.Next(0, this.Width), rdm.Next(0, this.Height), 10, 10));
                Thread.Sleep(50);
            }

            MessageBox.Show("Completed " + color);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            btnBlue_Click(sender, e);
            btnGreen_Click(sender, e);
            btnPink_Click(sender, e);
            btnRed_Click(sender, e);
        }
    }
}
