using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formes.Forms.Carre
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
