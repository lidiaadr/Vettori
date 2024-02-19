using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vettori
{
    internal class Vector
    {
        public Vector() { }

        public float X { get; set; }
        public float Y { get; set; }    
        public Vector(float x, float y)
        {
            X = x;
            Y = y;
        }

        public static Vector operator +(Vector v1, Vector v2) 
        { 
            return new Vector( v1.X + v2.X, v1.Y + v2.Y );
        }
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y );
        }
        public static Vector operator *(Vector v1, float a)
        {
            return new Vector( v1.X*a, v1.Y*a );
        }
        public static Vector operator *(float a, Vector v1)
        {
            return new Vector(a*v1.X, a*v1.Y);
        }
        public static Vector operator /(Vector v1, float a)
        {
            return new Vector(v1.X /a, v1.Y/a );    
        }
        public float Modulo(Vector v1)
        {
            return (float)Math.Sqrt(X * X + Y * Y);
        }
        public static Vector operator +(Vector v1)
        {
            return +v1;
        }
        public static Vector operator -(Vector v1)
        {
            return -v1;
        }
        public override string ToString()
        {
            return string.Format("{0}; {1}", X, Y);
        }
        public static Vector Parse(string s) 
        {
            string[] parts = s.Split(';');
            return new Vector(int.Parse(parts[0]), int.Parse(parts[1]));
        }

    }
}
