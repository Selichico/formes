using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formes.Forms.Cercle
{
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
