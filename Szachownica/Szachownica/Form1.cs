using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grafika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Brush b = Brushes.DarkRed;
            for (int i = 1; i <= 8; i += 2)
            {
                g.FillRectangle(b, 0, 100 * i+20, 100, 100);
                g.FillRectangle(b, 200, 100 * i+20, 100, 100);
                g.FillRectangle(b, 400, 100 * i+20, 100, 100);
                g.FillRectangle(b, 600, 100 * i+20, 100, 100);


                g.FillRectangle(b, 100 * i, 20, 100, 100);
                g.FillRectangle(b, 100 * i, 220, 100, 100);
                g.FillRectangle(b, 100 * i, 420, 100, 100);
                g.FillRectangle(b, 100 * i, 620, 100, 100);

            }
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 info = new Form3();
            info.Show();
        }

        private void autorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 autor = new Form2();
            autor.Show();
        }
    }
}
