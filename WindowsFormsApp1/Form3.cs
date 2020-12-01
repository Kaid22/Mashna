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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        Mashna m1, m2, m3;

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            m1.Crtaj(e.Graphics);
            m2.Crtaj(e.Graphics);
            m3.Crtaj(e.Graphics);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            m1.Premesti(ClientRectangle.Width, ClientRectangle.Height, r);
            m2.Premesti(ClientRectangle.Width, ClientRectangle.Height, r);
            m3.Premesti(ClientRectangle.Width, ClientRectangle.Height, r);
            Refresh();
        }

        Random r = new Random();

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Interval=800;

            int x = r.Next(ClientRectangle.Width);
            int y = r.Next(ClientRectangle.Height);
            m1 = new Mashna();
            m1.Postavi(new Point(x, y));

            x = r.Next(ClientRectangle.Width);
            y = r.Next(ClientRectangle.Height);
            m2 = new Mashna();
            m2.Postavi(new Point(x, y));

            x = r.Next(ClientRectangle.Width);
            y = r.Next(ClientRectangle.Height);
            m3 = new Mashna();
            m3.Postavi(new Point(x, y));
        }
    }
}
