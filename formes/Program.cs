using formes;

Point p = new Point();
p.Afficher();

p.X = 5;
p.Y = 10;
p.Afficher();

p.Deplacer(15, 20);
p.Afficher();

Point q = new Point { X = 30, Y = 10 };
q.Afficher();

q.Deplacer(p);
q.Afficher();

Point r = p;
r.Afficher();

r.Deplacer(35, 40);
p.Afficher();



