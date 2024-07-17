<<<<<<< HEAD
﻿namespace formes.Forms.Carre
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formes.Forms.Carre
>>>>>>> 47906e13e71cd96bc374e799e5210919e0bf4948
{
    public class Cube : Carre
    {

        public override double Superficie()
        {
            //return Longeur * Longeur * 6;
            return base.Superficie() * 6;
        }

    }
}
