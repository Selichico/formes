using formes.Forms;
using formes.Forms.Enum;

namespace formes.Forms.Carre
{
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
                    longeur = value;
            }
        }
<<<<<<< HEAD

        /// <summary>
        /// 
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="NotSupportedException"></exception>
=======
>>>>>>> 47906e13e71cd96bc374e799e5210919e0bf4948
        public Point this[PositionPoint position]
        {
            get
            {
                switch (position)
                {
                    case PositionPoint.HautGauche: return new Point { X = Origin.X, Y = Origin.Y };
                    case PositionPoint.HautDroite: return new Point { X = Origin.X + Longeur, Y = Origin.Y };
                    case PositionPoint.BasGauche: return new Point { X = Origin.X, Y = Origin.Y + Longeur };
                    case PositionPoint.BasDroite: return new Point { X = Origin.X + Longeur, Y = Origin.Y + Longeur };
                    default: throw new ArgumentOutOfRangeException(nameof(position));
                }
            }
            set
            {
                throw new NotSupportedException("impossible de changer les points carré");
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
}
