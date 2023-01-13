using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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
        Image kep;
        Rectangle hitbox;
        string objectfajta;

        static List<Mozgo> lista = new List<Mozgo>();
        
        //-----------------------------------------------------------------------
        

        public Mozgo(Vektor hely, Vektor sebesseg, Image kep, string fajta)
        {
            this.hely = hely;
            this.sebesseg = sebesseg;
            this.kep = kep;
            this.objectfajta = fajta;

            /*
            hitbox.X = (int)Math.Round(hely.X); //hitbox.X = (int)hely.X ez is mukodik lol
            hitbox.Y = (int)hely.Y;   
            hitbox.Width = kep.Width & hitbox.Height = kep.Height */

            hitbox.Size = new Size(kep.Width, kep.Height); 
            hitbox.Location = new Point((int)Math.Round(hely.X), (int)Math.Round(hely.Y));
            

            Mozgo.lista.Add(this);
        }




        //-------------------------------------------------------------------

        public static bool fut = false;

        internal void egylépés()
        {
            this.hely += this.sebesseg;
            hitbox.Y += (int)Math.Round(sebesseg.Y);        //hitbox.Y += (int)sebesseg.Y; is mukodik
            hitbox.X += (int)Math.Round(sebesseg.X);

            /*
            for (int i = 0; i < Mozgo.lista.Count(); i++)
            {
                for (int j = 1; j < Mozgo.lista.Count();j++)
                {
                    CollisionDetec(lista[i], lista[j]);
                    

                }
            }*/

        }

        public static void CollisionDetec(Mozgo egy, Mozgo ketto)
        {
            
            if (egy.hitbox.IntersectsWith(ketto.hitbox))
            {
                egy.sebesseg.Y *= -1; egy.sebesseg.X *= -1;
                ketto.sebesseg.Y *= -1; ketto.sebesseg.X *= -1;

                
                if (egy.objectfajta == "olló" && ketto.objectfajta == "kő")
                {
                    egy.objectfajta = "kő";
                    egy.kep = Image.FromFile("C:\\Users\\The User One\\Desktop\\projekt\\rock3.png");
                }
                else if (egy.objectfajta == "kő" && ketto.objectfajta == "olló")
                {
                    ketto.objectfajta = "kő";
                    ketto.kep = Image.FromFile("C:\\Users\\The User One\\Desktop\\projekt\\rock3.png");
                }

                else if (egy.objectfajta == "olló" && ketto.objectfajta == "papír")
                {
                    ketto.objectfajta = "olló";
                    ketto.kep = Image.FromFile("C:\\Users\\The User One\\Desktop\\projekt\\scissors3.png");
                }
                else if (egy.objectfajta == "papír" && ketto.objectfajta == "olló")
                {
                    egy.objectfajta = "olló";
                    egy.kep = Image.FromFile("C:\\Users\\The User One\\Desktop\\projekt\\scissors3.png");
                }

                else if (egy.objectfajta == "papír" && ketto.objectfajta == "kő")
                {
                    ketto.objectfajta = "papír";
                    ketto.kep = Image.FromFile("C:\\Users\\The User One\\Desktop\\projekt\\paper3.png");
                }
                else if (egy.objectfajta == "kő" && ketto.objectfajta == "papír") 
                {
                    egy.objectfajta = "papír";
                    egy.kep = Image.FromFile("C:\\Users\\The User One\\Desktop\\projekt\\paper3.png");
                }

                





            }
        }
       
        public static void Összes_léptetése(PictureBox picturebox1)
        {
            foreach (Mozgo mozgo in Mozgo.lista)
            {
                mozgo.egylépés();


                //COLLISION A TÖBBI OBJECTTEL
                for (int i = 0; i < Mozgo.lista.Count(); i++)
                {
                    CollisionDetec(mozgo, lista[i]);
                }


                //COLLISION A FALLAL
                if (mozgo.hely.X + 70 >= picturebox1.Width) //70 mert a kepek 70 pixel szelesek
                {
                    mozgo.sebesseg.X *= -1;
                }
                if (mozgo.hely.Y + 70 >= picturebox1.Height) //70 mert a kepek 70 pixel magasak
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


        //Egy olló, kő, vagy papír lerajzolása
        public void Lerajzol(Graphics g)
        {
            g.DrawImage(kep,new PointF(hely.X, hely.Y));
        }


        //Összes, ez nem változtatva eredeti kódhoz képest
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


        
        internal static void Szimuláció(PictureBox picturebox1, Label időlabel)
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
