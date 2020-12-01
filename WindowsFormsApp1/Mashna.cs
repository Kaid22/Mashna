using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Mashna
    {
        Point o;
        int a, b;
        Color boja;
        public void Postavi(Point o,int a,int b, Color boja)
        {
            this.o = o;
            this.a = a;
            this.b = b;
            this.boja = boja;
        }
        public void Postavi(Point o, int a, int b)
        {
            this.o = o;
            this.a = a;
            this.b = b;
            this.boja = Color.Red;
        }
        public void Postavi(Point o)
        {
            this.o = o;
            this.a = 120;
            this.b = 50;
            this.boja = Color.Red;
        }
        public void Crtaj(Graphics g)
        {
            Pen olovka = new Pen(boja, 7);
            SolidBrush cetka = new SolidBrush(Color.Black);
            g.DrawLine(olovka, o.X - a / 2, o.Y - b / 2, o.X - a / 2, o.Y + b / 2);
            g.DrawLine(olovka, o.X + a / 2, o.Y - b / 2, o.X + a / 2, o.Y + b / 2);
            g.DrawLine(olovka, o.X - a / 2, o.Y - b / 2, o.X + a / 2, o.Y + b / 2);
            g.DrawLine(olovka, o.X + a / 2, o.Y - b / 2, o.X - a / 2, o.Y + b / 2);
            g.FillEllipse(cetka, o.X - a / 8, o.Y - a / 8, a / 4, a / 4);
        }
        public void Pomeri(int dx,int dy)
        {
            o.X += dx;
            o.Y += dy;
        }
        public void Premesti(int sirina,int visina,Random r)
        {
            o.X = r.Next(a / 2, sirina - a / 2);
            o.Y = r.Next(b / 2, visina - b / 2);

        }
        public bool Sadrzi(Point tacka)
        {
            int razX = tacka.X - o.X;
            int razY = tacka.Y - o.Y;
            return (razX * razX + razY * razY) <= (a / 8) * (a / 8);
        }
    }
}
