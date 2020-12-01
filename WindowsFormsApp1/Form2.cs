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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random random = new Random();
        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            int a = 120;
            int b = 50;
            for (int x = a / 2; x < ClientRectangle.Width; x += a + 10) 
            {
                for(int y = b / 2; y < ClientRectangle.Height; y += b)
                {
                    int crvena = random.Next(256);
                    int zelena = random.Next(256);
                    int plava = random.Next(256);
                    Color boja = Color.FromArgb(crvena, zelena, plava);
                    Mashna mashna = new Mashna();
                    mashna.Postavi(new Point(x, y), a, b, boja);
                    mashna.Crtaj(e.Graphics);
                }
            }
        }
    }
}
