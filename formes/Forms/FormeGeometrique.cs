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
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 820fbaf728d065619cbe866b27e14c9990d0202e
        /// cette methode va nous permetre de comparer deux objet par rapport a leur superficie  
        ///this : refere a l'objet courant 
        /// this dans cette methode refere au objet1 ( objet courant) ""object1.equals(object2)""  
        /// 
<<<<<<< HEAD
=======
=======
>>>>>>> 820fbaf728d065619cbe866b27e14c9990d0202e
        /// cette methode va nous permetre de comparer duex objet par rapport a leur superficie  
        /// </summary>
        /// 
        ///                            this : refere a l'objet courant 
        /// 
        /// <returns></returns>
<<<<<<< HEAD
=======
>>>>>>> 47906e13e71cd96bc374e799e5210919e0bf4948
>>>>>>> 820fbaf728d065619cbe866b27e14c9990d0202e
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            if (obj is FormeGeometrique)
<<<<<<< HEAD
            {
                return this.Superficie() == (obj as FormeGeometrique).Superficie();
            }

=======
<<<<<<< HEAD
            {
                return this.Superficie() == (obj as FormeGeometrique).Superficie();
            }
=======
                return Superficie() == (obj as FormeGeometrique).Superficie();

>>>>>>> 47906e13e71cd96bc374e799e5210919e0bf4948
>>>>>>> 820fbaf728d065619cbe866b27e14c9990d0202e
            return false;
        }


    }
}
