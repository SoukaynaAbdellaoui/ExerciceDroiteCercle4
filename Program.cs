using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Droite
{
    private double m;
    private double b;

    //declaration d'un conctructeur avec des parametres 
    Droite()
    {
        m = 0;
        b = 0;
    }
    public void setm(double m)
    {
        this.m = m;
    }
    public double getm()
    {
        return m;
    }
    public void setb(double b)
    {
        this.b = b;
    }
    public double getb()
    {
        return b;
    }

    Droite(Point a, Point b)
    {
        m = (a.gety() - b.gety()) / (a.getx() - b.getx());
        this.b = a.gety() - (m * a.getx());
    }

    public bool Egalite(Droite droite)
    {
        return (m != droite.m || b != droite.b);

    }

    public bool parall(Droite droite)
    {
        return (m == droite.m);
    }

    public bool perpendicularité(Droite droite)
    {
        return (m == (-1 / droite.m));
    }

}



     internal class Cercle
    {
        private float rayon;
    
        public Cercle() 
        {
            rayon = 0;
        }
        public float getRayon()
        {
            return rayon;
        }
        public void setRayon(float radius)
        {
            this.rayon = radius;
        }


        public Cercle(Point center, float rayon) 
        {
            this.rayon= rayon;
        }

        public Cercle(float rayon)
        {
            this.rayon = rayon;
        }
        public double CalculAire()
        {
            return (rayon * rayon * Math.PI);
        }
        public bool Egalite(Cercle cercle)
        {
            return (rayon == cercle.rayon) ;
        }

        public double circonférence()
        {
            return (2 * rayon * Math.PI);
        }

      




    }



}
 
internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

