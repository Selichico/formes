using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using formes.Forms;

namespace formes.Forms.Enum
{
    /// <summary>
    /// enum : on l'utilise quand on a des valeur prédefinit exemple  
    /// </summary>
    public enum PositionPoint
    {
        HautGauche,
        HautDroite,
        BasGauche,
        BasDroite
    }

    public struct Ligne
    {
        public Point De { get; set; }
        public Point A { get; set; }
    }
    //public override string Tostring()
    // {
    //     return string.Format("[{0},{1}]", De, A);
    // } a revoire 
// equals elle verifier les adress par default dans la comparaison des objet 
//dans les structure par default elle verifier le contenue 
}