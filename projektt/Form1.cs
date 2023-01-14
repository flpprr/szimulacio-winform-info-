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
        //randomhely spawn
        static Random r = new Random();


        //OLLÓK
        Mozgo mozgo = new Mozgo(new Vektor(r.Next(1047), r.Next(473)), new Vektor(-1,-1), Image.FromFile("C:\\Users\\The User One\\Desktop\\projekt\\scissors3.png"), "olló");
        Mozgo mozgo2 = new Mozgo(new Vektor(r.Next(1047), r.Next(473)), new Vektor(1,1), Image.FromFile("C:\\Users\\The User One\\Desktop\\projekt\\scissors3.png"), "olló");
        Mozgo mozgo3 = new Mozgo(new Vektor(r.Next(1047), r.Next(473)), new Vektor(-1,1), Image.FromFile("C:\\Users\\The User One\\Desktop\\projekt\\scissors3.png"), "olló");

        //KÖVEK
        Mozgo mozgo4 = new Mozgo(new Vektor(r.Next(1047), r.Next(473)), new Vektor(1,1), Image.FromFile("C:\\Users\\The User One\\Desktop\\projekt\\rock3.png"), "kő");
        Mozgo mozgo5 = new Mozgo(new Vektor(r.Next(1047), r.Next(473)), new Vektor(-1,-1), Image.FromFile("C:\\Users\\The User One\\Desktop\\projekt\\rock3.png"), "kő");
        Mozgo mozgo6 = new Mozgo(new Vektor(r.Next(1047), r.Next(473)), new Vektor(-1,1), Image.FromFile("C:\\Users\\The User One\\Desktop\\projekt\\rock3.png"), "kő");

        //PAPÍROK
        Mozgo mozgo7 = new Mozgo(new Vektor(r.Next(1047), r.Next(473)), new Vektor(-1,-1), Image.FromFile("C:\\Users\\The User One\\Desktop\\projekt\\paper3.png"), "papír");
        Mozgo mozgo8 = new Mozgo(new Vektor(r.Next(1047), r.Next(473)), new Vektor(1,-1), Image.FromFile("C:\\Users\\The User One\\Desktop\\projekt\\paper3.png"), "papír");
        Mozgo mozgo9 = new Mozgo(new Vektor(r.Next(1047), r.Next(473)), new Vektor(1,1), Image.FromFile("C:\\Users\\The User One\\Desktop\\projekt\\paper3.png"), "papír");



        public Form1()
        {
            InitializeComponent();
            Mozgo.Összes_lerajzolása(pictureBox1);
            
        }

        //start
        private void circbutton1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            Mozgo.fut = true;
            Mozgo.Szimuláció(pictureBox1, label1, label2);

            
        }

        


        //stop
        private void circbutton2_Click(object sender, EventArgs e)
        {
            Mozgo.fut = false;
            timer1.Enabled = false;
        }

        
        //sec counter
        int i = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = i.ToString();
            i++;
            
        }

        //kilép 
        private void circbutton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
