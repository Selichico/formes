//using formes;
//using System.ComponentModel.Design.Serialization;

//Program2.main(null); 

//Point p = new Point();
//p.Afficher();

//p.X = 5;
//p.Y = 10;
//p.Afficher();

//p.Deplacer(15, 20);
//p.Afficher();
////creation point q de la class Point
//Point q = new Point { X = 30, Y = 10 };
//q.Afficher();


//q.Deplacer(p);
//q.Afficher();

//Console.WriteLine(p == q);
//Console.WriteLine(p.Equals(q));

//Point r = p;
//r.Afficher();

//r.Deplacer(35, 40);
//p.Afficher();

//Carre squar = new Carre();

//squar.Longeur = 20;
//squar.Nom = "carre";  

//Console.WriteLine(squar.Superficie());

//squar.origin.Deplacer(50, 60);

//Console.WriteLine(squar);

//var tab = new FormeGeometrique[] { new Carre { Longeur = 20 }, new Rectangle { Longeur = 20, Largeur = 30}, new Cube { Longeur=15},
//                                    new Cercle{ Rayon= 10}, new Sphere{ Rayon=5} };

//var fg = tab[1];

//Rectangle rr = fg as Rectangle;
//if (rr != null) { 
//Console.WriteLine(rr.Largeur);
//}

//Carre cc = new Carre { origin= new Point { X = 5, Y = 10 }, Longeur = 20  };

//Console.WriteLine(cc[PositionPoint.HautGauche]);


//Point pp = new Point { X = 5, Y = 10 };
//Point pp2 = new Point { Y = 30, X = 15 };  

//Ligne l1 = new Ligne();
//l1.De = pp;
//l1.A = pp2; 

//Ligne l2 = new Ligne();
//l2.De = pp;
//l2.A = pp2;
//bool test = l1.Equals(l2);
//Console.WriteLine("l1= l2 ?" + test);

using formes;

var employees = new List<Employe>
{
    new Employe { Id = 1, Nom= "Mohamed", DateNaissance = DateTime.Parse("1994/01/11"), Marie=true, Sex ='m',Salaire = 3333, IdDepartement =1 },
    new Employe { Id = 2, Nom= "aymen", DateNaissance = DateTime.Parse("1955/09/19"), Marie=false, Sex ='m',Salaire = 6336, IdDepartement =2 },
    new Employe { Id = 3, Nom= "Manel", DateNaissance = DateTime.Parse("1976/05/23"), Marie=true, Sex ='f',Salaire = 2332, IdDepartement =2 },
    new Employe { Id = 4, Nom= "Asia", DateNaissance = DateTime.Parse("2000/11/25"), Marie=true, Sex ='f',Salaire = 4334, IdDepartement =3 },
    new Employe { Id = 5, Nom= "Said", DateNaissance = DateTime.Parse("1991/09/30"), Marie=false, Sex ='m',Salaire = 5335, IdDepartement =3 },
    new Employe { Id = 6, Nom= "Brahim", DateNaissance = DateTime.Parse("1988/12/31"), Marie=true, Sex ='m',Salaire = 1331, IdDepartement =2 },
    new Employe { Id = 7, Nom= "Mohamed", DateNaissance = DateTime.Parse("2006/01/8"), Marie=false, Sex ='m',Salaire = 9339, IdDepartement =3 },

};
var depts = new List<Departement>
{
     new Departement {Id=1,Intitule="RH" },
    new Departement {Id=2,Intitule="FC" },
    new Departement {Id=3,Intitule="IT" },
};

var l1 = from x in employees where x.Salaire>5000 select x;

foreach(var x in l1)
{
    Console.WriteLine(x.Id);
}
Console.WriteLine("-----");


var l2 = from x in employees where x.Marie && x.Sex=='m' select x;

foreach (var x in l2)
{
    Console.WriteLine(x.Id);
}
Console.WriteLine("-----");

var l3 = from x in employees  select new { x.Id, x.Nom};

foreach (var x in l3)
{
    Console.WriteLine( x.Nom);
}
Console.WriteLine("-----");

var l5 = from x in employees orderby x.Nom select x;
foreach (var x in l5)
{
    Console.WriteLine(x.Nom);
}
Console.WriteLine("-----");

var l6 = from x in employees orderby x.Salaire descending, x.Sex select x;
foreach (var x in l6)
{
    Console.WriteLine(x.Id +":"+ x.Nom + ":"+ x.Salaire +":" +x.Sex);
}
Console.WriteLine("-----");

var l7 = from x in employees group x by x.IdDepartement into g select g; // ou faire comme ca 
//var l7 = from x in employees group x by x.IdDepartement into g select g select new {Departement = g.Key, Employe = g }
foreach (var x in l7)
{
    Console.WriteLine("departement"+ x.Key);
    foreach(var y in x)
    {
        Console.WriteLine("\t"+ y.Nom);
    }
}
Console.WriteLine("-----");


var l8 = from x in employees join y in depts on x.IdDepartement equals y.Id orderby y.Intitule select new {Employe = x,Departement = y};
foreach (var x in l8)
{
    Console.WriteLine(string.Format("{0,-10}-->{1}" , x.Employe.Nom , x.Departement.Intitule));
}
