using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Mashna mashna;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mashna = new Mashna();
            int x = ClientRectangle.Width / 2;
            int y = ClientRectangle.Height / 2;
            int crvena = r.Next(256);
            int zelena = r.Next(256);
            int plava = r.Next(256);
            Color boja = Color.FromArgb(crvena, zelena, plava);
            mashna.Postavi(new Point(x, y), 150, 70, boja);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            mashna.Crtaj(e.Graphics);
        }
        bool pomeranje = false;
        int xPre, Ypre;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pomeranje)
            {
                mashna.Pomeri(e.X - xPre, e.Y - Ypre);
                xPre = e.X;
                Ypre = e.Y;
                Refresh();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            pomeranje = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Point tacka = new Point(e.X, e.Y);
            if (mashna.Sadrzi(tacka))
            {
                pomeranje = true;
                xPre = e.X;
                Ypre = e.Y;
            }
        }
    }
}
