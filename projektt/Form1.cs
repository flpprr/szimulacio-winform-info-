using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projektt
{
    public partial class Form1 : Form
    {


        Mozgo mozgo = new Mozgo(new Vektor(100, 100), new Vektor(1, 1), 30, Color.Blue);
        Mozgo mozgo2 = new Mozgo(new Vektor(400, 380), new Vektor(1, 1), 30, Color.DarkGreen);
        Mozgo mozgo3 = new Mozgo(new Vektor(180, 60), new Vektor(1, 1), 30, Color.White);
        Mozgo mozgo4 = new Mozgo(new Vektor(270, 200), new Vektor(1, 1), 30, Color.DarkGreen);
        Mozgo mozgo5 = new Mozgo(new Vektor(410, 110), new Vektor(1, 1), 30, Color.Blue);
        Mozgo mozgo6 = new Mozgo(new Vektor(350, 120), new Vektor(1, 1), 30, Color.Blue);
        Mozgo mozgo7 = new Mozgo(new Vektor(420, 300), new Vektor(1, 1), 30, Color.White);
        Mozgo mozgo8 = new Mozgo(new Vektor(60, 320), new Vektor(1, 1), 30, Color.DarkGreen);
        Mozgo mozgo9 = new Mozgo(new Vektor(300, 450), new Vektor(1, 1), 30, Color.White);

        

        public Form1()
        {
            InitializeComponent();
            Mozgo.Összes_lerajzolása(körPicturebox1);
            Mozgo.Összes_léptetése();
            körPicturebox1.Refresh();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            Mozgo.fut = true;
            Mozgo.Szimuláció(körPicturebox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mozgo.fut = false;
        }
    }
}
