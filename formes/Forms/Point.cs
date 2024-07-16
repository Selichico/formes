using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using formes.Forms.Enum;
///


namespace formes.Forms //c'est un regroupement logic des fichier ( class objet ..) 
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


        /// <summary>
        ///   on affecte de nouvel valeur a au proprieté X et Y 
        /// </summary>
        /// 
        public void Deplacer(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// on a surcharger cette methode 
        /// on affecte au nouveau point les propriete X & Y de l'objet afin que le nouveu point 
        /// ce deplace au point de l'objet 
        /// </summary>
        /// 
        public void Deplacer(Point other)
        {
            //X=other.X; Y=other.Y;
            Deplacer(other.X, other.Y);
        }
        public void Afficher()
        {
            Console.WriteLine("[ " + X + ";" + Y + " ]");
        }

        /// <summary>
        /// cette methode elle va cnvertir notre objet en json et le retourner dans une string 
        /// </summary>
        /// il vas serialize les proprieté 
        /// <returns></returns>
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }

        /// <summary>
        ///  dans cette methode on est entrain de comparer deux objet par rapport a leur membre x et y 
        /// </summary>
        /// <returns>boolan </returns>
        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj is Point)
            {
                return X == (obj as Point).X && Y == (obj as Point).Y;
            }
                return false;
        }

        /// <summary>
        /// c'est une surcharge de l'operateur arithmétiques + , avec une opération binair  
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Ligne operator +(Point a, Point b)
        {
            return new Ligne { De = a, A = b };

        }

    }




}

