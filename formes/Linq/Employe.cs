<<<<<<< HEAD
﻿namespace formes.Linq
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formes.Linq
>>>>>>> 47906e13e71cd96bc374e799e5210919e0bf4948
{
    public class Employe
    {

        public int Id { get; set; } = 0;
        public string Nom { get; set; } = string.Empty;
        public DateTime DateNaissance { get; set; } = DateTime.Now;
        public bool Marie { get; set; } = false;
        public char Sex { get; set; } = 'm';
        public double Salaire { get; set; } = 1800;
        public int IdDepartement { get; set; }
    }
<<<<<<< HEAD
    
=======
    public class Departement
    {
        public int Id { get; set; } = 0;
        public string Intitule { get; set; } = string.Empty;
    }
>>>>>>> 47906e13e71cd96bc374e799e5210919e0bf4948
}
