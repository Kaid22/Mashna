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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        Mashna[] m = new Mashna[10];
        int n = 0;
        Random r = new Random();

        private void Form4_Load(object sender, EventArgs e)
        {
            n = r.Next(5, 11);
            for(int i = 0; i < n; i++)
            {
                int x = r.Next(ClientRectangle.Width);
                int y = r.Next(ClientRectangle.Height);
                int a = r.Next(30, 50);
                m[i] = new Mashna();
                m[i].Postavi(new Point(x, y), a, a / 2);

            }

        }

        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            for(int i = 0; i < n; i++)
            {
                m[i].Crtaj(e.Graphics);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                m[i].Premesti(ClientRectangle.Width, ClientRectangle.Height, r);

            }
            Refresh();
        }

        private void Form4_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }
    }
}
