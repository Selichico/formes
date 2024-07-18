<<<<<<< HEAD
=======
<<<<<<< HEAD
﻿using System.Text.Json;

namespace formes.Forms.Carre
{
    public class Rectangle : Carre
=======
>>>>>>> 820fbaf728d065619cbe866b27e14c9990d0202e
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using formes.Forms;

namespace formes.Forms.Carre
{
<<<<<<< HEAD
    public class Rectangle : Carre

=======
    public class Rectangle : FormeGeometrique
>>>>>>> 47906e13e71cd96bc374e799e5210919e0bf4948
>>>>>>> 820fbaf728d065619cbe866b27e14c9990d0202e
    {


        private int largeur;

        public int Largeur
        {
            get
            {
                return largeur;
            }
            set
            {
                if (value >= 0)
                    largeur = value;
            }
        }

<<<<<<< HEAD
=======
<<<<<<< HEAD

=======
>>>>>>> 47906e13e71cd96bc374e799e5210919e0bf4948
>>>>>>> 820fbaf728d065619cbe866b27e14c9990d0202e
        public override double Superficie()
        {
            return Longeur * Largeur;
        }
        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }

    }
}
