<<<<<<< HEAD
﻿namespace formes.Forms.Cercle
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using formes.Forms;

namespace formes.Forms.Cercle
>>>>>>> 47906e13e71cd96bc374e799e5210919e0bf4948
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
