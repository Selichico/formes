using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace formes.Forms
{
    /// <summary>
    /// on crée on class abstracte d'une part pour quel soit pas implémenter(instancier) et d'autre part toute 
    /// les classe fils on besoin de ses parametre(c'est des parametre en commun )
    /// quand on declare une methode abstract on doit la mettre dans une class abstract 
    /// </summary>
    ///une class abstract on peut pas l'implémenter 
    public abstract class FormeGeometrique
    {

        public int origine;
        public string nom;

        public Point Origin { get; set; } = new Point();
        public string Nom { get; set; }

        /// <summary>
        /// c'est une methode abstract qui va calculer la superficier de l'objet 
        /// </summary>
        /// <returns></returns>
        public abstract double Superficie();

        /// <summary>
        /// cette methode elle va cnvertir notre objet en json et le retourner dans une string 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }

        /// <summary>
        /// cette methode va nous permetre de comparer deux objet par rapport a leur superficie  
        ///this : refere a l'objet courant 
        /// this dans cette methode refere au objet1 ( objet courant) ""object1.equals(object2)""  
        /// 
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            if (obj is FormeGeometrique)
            {
                return this.Superficie() == (obj as FormeGeometrique).Superficie();
            }
            return false;
        }


    }
}
