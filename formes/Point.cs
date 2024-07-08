using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
///


namespace formes //c'est un regroupement logic des fichier ( class objet ..) 
{
    public class Point
    {
        private int x;
        private int y;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                if (value >= 0)
                    x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                if (value >= 0)
                    y = value;
            }
        }

        public void Deplacer(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Deplacer(Point other)
        {
            //X=other.X; Y=other.Y;
            Deplacer(other.X, other.Y);
        }
        public void Afficher()
        {
            Console.WriteLine("[ " + X + ";" + Y + " ]");
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
        public bool Equals(Point obj)
        {
            return X == obj.X && Y == obj.Y;
        }
    }


    public abstract class FormeGeometrique//une class abstract on peut pas l'implémenter 
    {
        public int origine;
        public string nom;

        public Point origin { get; set; } = new Point();
        public string Nom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract double Superficie();//quand on declare une methode abstract on doit la mettre dans une class abstract 
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            if (obj is FormeGeometrique)
                return Superficie() == (obj as FormeGeometrique).Superficie();

            return false;
        }
        
        
    }

    public class Carre : FormeGeometrique
    {
        protected int longeur;
        public int Longeur
        {
            get
            {
                return longeur;
            }
            set
            {
                if (value >= 0)
                   longeur  = value;
            }
        }
        public override double Superficie()
        {
            return Longeur * Longeur;
        }
        public virtual double Volume()
        {
            return longeur * longeur * longeur;
        }
    }
    public class Rectangle : Carre
    {

        private int largeur;

        public int Largeur
        {
            get
            {
                return largeur;
            }
            set
            {
                if (value >= 0)
                    largeur = value;
            }
        }

        public override double Superficie()
        {
            return Longeur * Largeur;
        }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
    public class Cube : Carre
    {


        public override double Superficie()
        {
            //return Longeur * Longeur * 6;
            return base.Superficie() * 6;
        }

    }

    public class Cercle : FormeGeometrique
    {
        private int rayon;
        public int Rayon
        {
            get
            {
                return rayon;
            }
            set
            {
                rayon = Math.Abs(value);

            }
        }
        public override double Superficie()
        {
            return Math.PI * rayon * rayon;
        }
    }

    public class Sphere : Cercle
    {

        public override double Superficie()
        {
            return 4 * base.Superficie();
        }
        public virtual double Volume()
        {
            return 4 / 3 * Math.PI * Math.Pow(Rayon, 3);
        }
    }

}

