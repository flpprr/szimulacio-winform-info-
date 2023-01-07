using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projektt
{
    class Mozgo
    {
        Vektor hely;
        Vektor sebesseg;
        int tomeg;
        Image kep;

        static List<Mozgo> lista = new List<Mozgo>();
        List<Vektor> elmozdulasai;

        //----------------
        

        public Mozgo(Vektor hely, Vektor sebesseg, int tomeg, Image kep)
        {
            this.hely = hely;
            this.sebesseg = sebesseg;
            this.tomeg = tomeg;
            this.kep = kep;
            
           
            this.elmozdulasai = new List<Vektor>();
            Mozgo.lista.Add(this);
        }

        

        public static bool fut = false;
        public static int idő = 0;



        internal void Lépj()
        {
            this.hely += this.sebesseg;
            
        }
        public static void Összes_léptetése(PictureBox picturebox1)
        {
            foreach (Mozgo mozgo in Mozgo.lista)
            {
                mozgo.Lépj();

                if (mozgo.hely.X + 70 >= picturebox1.Width) //70 mert a kepek 70 pixel szelesek
                {
                    mozgo.sebesseg.X *= -1;
                }
                if (mozgo.hely.Y + 70 >= picturebox1.Height) //70 mert a kepek 70 pixel magasas
                {
                    mozgo.sebesseg.Y *= -1;
                }
                if (mozgo.hely.X <= 0) //2
                {
                    mozgo.sebesseg.X *= -1;
                }
                if (mozgo.hely.Y <= 0)  //2
                {
                    mozgo.sebesseg.Y *= -1;
                }

            }
        }
        public void Lerajzol(Graphics g)
        {
            g.DrawImage(kep,new PointF(hely.X, hely.Y));
        }
        public static void Összes_lerajzolása(PictureBox picturebox1)
        {
            Size vaszonmeret = picturebox1.Size;
            Bitmap bmp = new Bitmap(vaszonmeret.Width, vaszonmeret.Height);
            picturebox1.Image = bmp;
            using (Graphics g = Graphics.FromImage(bmp))
            {
                foreach (Mozgo mozgo in Mozgo.lista)
                {
                    mozgo.Lerajzol(g);
                }
            }
            picturebox1.Refresh();
        }
        internal static void Szimuláció(PictureBox picturebox1)
        {
            while (fut)
            {
                Thread.Sleep(20);
                
                Mozgo.Összes_lerajzolása(picturebox1);
                Mozgo.Összes_léptetése(picturebox1);
                      
                Application.DoEvents();
            }
        }








    }
}
