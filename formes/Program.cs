using formes;

Program2.main(null); 

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

Console.WriteLine(squar.Superficie());

squar.origin.Deplacer(50, 60);

Console.WriteLine(squar);

var tab = new FormeGeometrique[] { new Carre { Longeur = 20 }, new Rectangle { Longeur = 20, Largeur = 30}, new Cube { Longeur=15},
                                    new Cercle{ Rayon= 10}, new Sphere{ Rayon=5} };

var fg = tab[1];

Rectangle rr = fg as Rectangle;
if (rr != null) { 
Console.WriteLine(rr.Largeur);
}
