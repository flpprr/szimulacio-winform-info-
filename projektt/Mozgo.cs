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
        Color szin;
        SolidBrush kemenyecset;


        static List<Mozgo> lista = new List<Mozgo>();
        List<Vektor> elmozdulasai;

        //----------------
        

        public Mozgo(Vektor hely, Vektor sebesseg, int tomeg, Color szin)
        {
            this.hely = hely;
            this.sebesseg = sebesseg;
            this.tomeg = tomeg;
            this.szin = szin;
            this.kemenyecset = new SolidBrush(szin);

            this.elmozdulasai = new List<Vektor>();
            Mozgo.lista.Add(this);
        }

        

        public static bool fut = false;
        public static int idő = 0;



        internal void Lépj()
        {
            this.hely += this.sebesseg;
        }

        public static void Összes_léptetése()
        {
            foreach (Mozgo mozgo in Mozgo.lista)
            {
                mozgo.Lépj();
            }
        }

        public void Lerajzol(Graphics g)
        {
            Point h = hely.ToPoint();
            g.FillEllipse(kemenyecset, h.X - tomeg / 2, h.Y - tomeg / 2, tomeg, tomeg);
        }

        public static void Összes_lerajzolása(KörPicturebox körPicturebox1)
        {
            Size vaszonmeret = körPicturebox1.Size;
            Bitmap bmp = new Bitmap(vaszonmeret.Width, vaszonmeret.Height);
            körPicturebox1.Image = bmp;
            using (Graphics g = Graphics.FromImage(bmp))
            {
                foreach (Mozgo mozgo in Mozgo.lista)
                {
                    mozgo.Lerajzol(g);
                }
            }
            körPicturebox1.Refresh();
        }


        internal static void Szimuláció(KörPicturebox körPicturebox1)
        {
            while (fut)
            {
                Thread.Sleep(20);
                
                Mozgo.Összes_lerajzolása(körPicturebox1);
                Mozgo.Összes_léptetése();
                      
                Application.DoEvents();
            }
        }








    }
}
