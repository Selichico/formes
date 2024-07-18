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
using formes.Forms;

namespace formes.Forms.Cercle
<<<<<<< HEAD
=======
>>>>>>> 47906e13e71cd96bc374e799e5210919e0bf4948
>>>>>>> 820fbaf728d065619cbe866b27e14c9990d0202e
{
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
}
