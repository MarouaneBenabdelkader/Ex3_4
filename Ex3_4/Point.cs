using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public class Point
    {
        public float x { get; set; }
        public float y { get; set; }


        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public void SetX(float x = 0)
        {
            this.x = x;
        }
        public void setY(float y)
        {
            this.y = y;
        }
        public float GettX()
        {
            return this.x;
        }
        public float GettY()
        {
            return this.y;
        }

        public Boolean Egalite(Point p)
        {
            return this.x == p.x && this.y == p.y;
        }

        public double Distance(Point B)
        {
            return Math.Sqrt(Math.Pow((x - B.x), 2) + Math.Pow((y - B.y), 2));
        }

        public void Translation(float dx, float dy)
        {
            x += dx;
            y += dy;
        }
        public Boolean Linearite(Point B, Point C)
        {
            // On determine l'equation de la droit
            float a = (B.y - x) / (B.x - x);
            float b = y - (a * x);
            return C.y == a * C.x + b;
        }
    }
}
