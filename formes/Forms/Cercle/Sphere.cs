<<<<<<< HEAD
=======
<<<<<<< HEAD
﻿namespace formes.Forms.Cercle
=======
>>>>>>> 820fbaf728d065619cbe866b27e14c9990d0202e
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formes.Forms.Cercle
<<<<<<< HEAD
=======
>>>>>>> 47906e13e71cd96bc374e799e5210919e0bf4948
>>>>>>> 820fbaf728d065619cbe866b27e14c9990d0202e
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
