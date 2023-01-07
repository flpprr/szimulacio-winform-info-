using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektt
{
    public class Vektor
    {
        public float X, Y;

        public Vektor(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public static Vektor operator +(Vektor a, Vektor b) => new Vektor(a.X + b.X, a.Y + b.Y);
        public static Vektor operator -(Vektor a, Vektor b) => new Vektor(a.X - b.X, a.Y - b.Y);

    }
}
