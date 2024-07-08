using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            Console.WriteLine("[ " + X+";"+Y+" ]");
        }
    }

    public abstract class FormeGeometrique//une class abstract on peut pas l'implémenter 
    {
        public int origine;
        public string nom;

        public Point origin { get; set; }
        public string Nom { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract double Superficie();//quand on declare une methode abstract on doit la mettre dans une class abstract 
       
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
                    value = longeur;
            }
        }
        public override double Superficie()
        {
            return Longeur * Longeur;
        }
    }
    public class Rectangle : Carre
    {
       
        private int largeur;
       
        public int Largeur
        {
            get
            {
                return Largeur;
            }
            set
            {
                if (value >= 0)
                    value = Largeur;
            }
        }

        public override double Superficie()
        {
            return Longeur * Largeur;
        }
    }
    public class Cube : Carre
    {

         

        

        public override double Superficie()
        {
            return Longeur * Longeur * Longeur;
        }

    }
}
