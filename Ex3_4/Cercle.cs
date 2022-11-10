using Ex3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_4
{
    public class Cercle
    {
        private Point p;
        private int r;
        Cercle(Point p, int r)
        {
            this.p = p;
            this.r = r;
        }
        public void SetRayon(int r)
        {
            this.r = r;
        }
        public void setPoint(Point p)
        {
            this.p = p;
        }

        public int GetRayon()
        {
            return this.r;
        }

        public Point GetPoint()
        {
            return this.p;
        }

        public Boolean EgaliteCercle(Cercle c)
        {
           return c.r == this.r * 2 * Math.PI;

        }

        public Boolean Intersection(Cercle c)
        {
            double distance = Math.Sqrt(Math.Pow(c.p.x - this.p.x, 2) + Math.Pow(c.p.y - this.p.y, 2));
            if(distance > this.r + c.r || distance < this.r - c.r)
            {
                return false;
            }
            return true;
        }

        public double Aire()
        {
            return r * r * Math.PI;
        }



    }
}
