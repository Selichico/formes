using formes;
using formes.Forms;
using formes.Forms.Carre;
using formes.Forms.Cercle;
using formes.Forms.Enum;
using formes.Linq;
using System.ComponentModel.Design.Serialization;


Program2.main(null);

#region exo partie geometrique 


Point p = new Point();
p.Afficher();

p.X = 5;
p.Y = 10;
p.Afficher();

p.Deplacer(15, 20);
p.Afficher();
//creation point q de la class Point
Point q = new Point { X = 30, Y = 10 };
q.Afficher();


q.Deplacer(p);
q.Afficher();

Console.WriteLine(p == q);
Console.WriteLine(p.Equals(q));

Point r = p;
r.Afficher();

r.Deplacer(35, 40);
p.Afficher();

Carre squar = new Carre();
squar.Longeur = 20;
squar.Nom = "carre";

Carre squar2 = new Carre();
squar2.Longeur = 30;

var result  = squar.Equals(squar2);

//squar[PositionPoint.BasDroite];


Console.WriteLine(squar.Superficie());

squar.Origin.Deplacer(50, 60);

Console.WriteLine(squar);

var tab = new FormeGeometrique[] { new Carre { Longeur = 20 }, new Rectangle { Longeur = 20, Largeur = 30}, new Cube { Longeur=15},
                                    new Cercle{ Rayon= 10}, new Sphere{ Rayon=5} };

var fg = tab[1];

Rectangle rr = fg as Rectangle;
if (rr != null)
{
    Console.WriteLine(rr.Largeur);
}

Carre cc = new Carre { Origin = new Point { X = 5, Y = 10 }, Longeur = 20 };

Console.WriteLine(cc[PositionPoint.HautGauche]);


Point pp = new Point { X = 5, Y = 10 };
Point pp2 = new Point { Y = 30, X = 15 };

Ligne line = new Ligne();
line.De = pp;
line.A = pp2;

Ligne line2 = new Ligne();
line2.De = pp;
line2.A = pp2;
bool test = line.Equals(line2);
Console.WriteLine("l1= l2 ?" + test);

#endregion



#region partie Linq 

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

//var l1 = from x in employees where x.Salaire>5000 select x;
var l1 = employees.Where(x => x.Salaire > 5000).Select(x => x);
foreach (var x in l1)
{
    Console.WriteLine(x.Id);
}
Console.WriteLine("-----");

//var l2 = from x in employees where x.Marie && x.Sex=='m' select x;
var l2 = employees.Where(x => x.Marie && x.Sex == 'm').Select(x => x);
foreach (var x in l2)
{
    Console.WriteLine(x.Id);
}
Console.WriteLine("-----");

//var l3 = from x in employees  select new { x.Id, x.Nom};
var l3 = employees.Select(x => new { x.Id, x.Nom });
foreach (var x in l3)
{
    Console.WriteLine(x.Nom);
}
Console.WriteLine("-----");

//var l5 = from x in employees orderby x.Nom select x;
var l5 = employees.OrderBy(x => x.Nom).Select(x => x);
foreach (var x in l5)
{
    Console.WriteLine(x.Nom);
}
Console.WriteLine("-----");

//var l6 = from x in employees orderby x.Salaire descending, x.Sex select x;
var l6 = employees.OrderByDescending(x => x.Salaire).ThenBy(x => x.Sex).Select(x => x);

foreach (var x in l6)
{
    Console.WriteLine(x.Id + ":" + x.Nom + ":" + x.Salaire + ":" + x.Sex);
}
Console.WriteLine("-----");

//var l7 = from x in employees group x by x.IdDepartement into g select g; // ou faire comme ca 
//var l7 = from x in employees group x by x.IdDepartement into g select g select new {Departement = g.Key, Employe = g }
var l7 = employees.GroupBy(x => x.IdDepartement).Select(g => g);
foreach (var x in l7)
{
    //var dept = (from a in depts where a.Id == x.departement select a.intitule).ToArray()[0];
    var dept = depts.Single(a => a.Id == x.Key);
    Console.WriteLine("departement" + dept.Intitule);
    foreach (var y in x)
    {
        Console.WriteLine("\t" + y.Nom);
    }
}
Console.WriteLine("-----");
var l10 = employees.OrderByDescending(x => x.DateNaissance).Select(x => x);
foreach (var x in l10)
{
    Console.WriteLine(x.DateNaissance);
}


//var l8 = from x in employees join y in depts on x.IdDepartement equals y.Id orderby y.Intitule select new {Employe = x,Departement = y};

var l8 = employees.Join(depts, x => x.IdDepartement, y => y.Id, (x, y) => new { Employe = x, Departement = y });

foreach (var x in l8)
{
    Console.WriteLine(string.Format("{0,-10}-->{1}", x.Employe.Nom, x.Departement.Intitule));
}


// la varieble l9 n'est pas excuter jusqua que on fait al=ppelle a elle sauf si on ajout .ToList
var l9 = employees.Select(x => x.Sex).Distinct();
foreach (var x in l9)
{
    Console.WriteLine(x);
}
Console.WriteLine("---------");

///en SQL les fonction vertical ou les agrégat 

Console.WriteLine("salaire MIn :" + employees.Min(x => x.Salaire));
Console.WriteLine("salaire Max :" + employees.Max(x => x.Salaire));
Console.WriteLine("salaire Moyen :" + employees.Average(x => x.Salaire));
Console.WriteLine("salaire sum :" + employees.Sum(x => x.Salaire));


#endregion

