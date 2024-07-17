<<<<<<< HEAD
﻿using System.Text.Json;

namespace formes.Forms.Carre
{
    public class Rectangle : Carre
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using formes.Forms;

namespace formes.Forms.Carre
{
    public class Rectangle : FormeGeometrique
>>>>>>> 47906e13e71cd96bc374e799e5210919e0bf4948
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
>>>>>>> 47906e13e71cd96bc374e799e5210919e0bf4948
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
