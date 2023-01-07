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
        
        Mozgo mozgo = new Mozgo(new Vektor(100, 100), new Vektor(1, 1), 0, Image.FromFile("C:\\Users\\The User One\\Desktop\\projekt\\scissors3.png"));
        Mozgo mozgo2 = new Mozgo(new Vektor(700, 320), new Vektor(-1, 1), 0, Image.FromFile("C:\\Users\\The User One\\Desktop\\projekt\\scissors3.png"));
        Mozgo mozgo3 = new Mozgo(new Vektor(180, 60), new Vektor(1, -1), 0, Image.FromFile("C:\\Users\\The User One\\Desktop\\projekt\\scissors3.png"));
        Mozgo mozgo4 = new Mozgo(new Vektor(270, 200), new Vektor(1, 1), 0, Image.FromFile("C:\\Users\\The User One\\Desktop\\projekt\\rock3.png"));
        Mozgo mozgo5 = new Mozgo(new Vektor(410, 110), new Vektor(1, -1), 0, Image.FromFile("C:\\Users\\The User One\\Desktop\\projekt\\rock3.png"));
        Mozgo mozgo6 = new Mozgo(new Vektor(320, 120), new Vektor(-1, 1), 0, Image.FromFile("C:\\Users\\The User One\\Desktop\\projekt\\rock3.png"));
        Mozgo mozgo7 = new Mozgo(new Vektor(420, 300), new Vektor(1, -1), 0, Image.FromFile("C:\\Users\\The User One\\Desktop\\projekt\\paper3.png"));
        Mozgo mozgo8 = new Mozgo(new Vektor(60, 320), new Vektor(1, 1), 0, Image.FromFile("C:\\Users\\The User One\\Desktop\\projekt\\paper3.png"));
        Mozgo mozgo10 = new Mozgo(new Vektor(600, 450), new Vektor(-1, 1), 0, Image.FromFile("C:\\Users\\The User One\\Desktop\\projekt\\paper3.png"));

        public Form1()
        {
            InitializeComponent();
            Mozgo.Összes_lerajzolása(pictureBox1);

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            Mozgo.fut = true;
            Mozgo.Szimuláció(pictureBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mozgo.fut = false;
        }
    }
}
