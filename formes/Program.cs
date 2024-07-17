using formes;
using formes.Forms;
using formes.Forms.Carre;
using formes.Forms.Cercle;
using formes.Forms.Enum;
using formes.Linq;
using formes.Programation_Asynchronne;
using System.ComponentModel.Design.Serialization;


//Program2.main(null);

//#region exo partie geometrique 


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

//<<<<<<< HEAD

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

//Carre squar2 = new Carre();
//squar2.Longeur = 30;

//var result  = squar.Equals(squar2);

////squar[PositionPoint.BasDroite];


//Console.WriteLine(squar.Superficie());

//squar.Origin.Deplacer(50, 60);

//Console.WriteLine(squar);

//var tab = new FormeGeometrique[] { new Carre { Longeur = 20 }, new Rectangle { Longeur = 20, Largeur = 30}, new Cube { Longeur=15},
//                                    new Cercle{ Rayon= 10}, new Sphere{ Rayon=5} };

//var fg = tab[1];

//Rectangle rr = fg as Rectangle;
//if (rr != null)
//{
//    Console.WriteLine(rr.Largeur);
//}

//Carre cc = new Carre { Origin = new Point { X = 5, Y = 10 }, Longeur = 20 };

//Console.WriteLine(cc[PositionPoint.HautGauche]);


//Point pp = new Point { X = 5, Y = 10 };
//Point pp2 = new Point { Y = 30, X = 15 };

//Ligne line = new Ligne();
//line.De = pp;
//line.A = pp2;

//Ligne line2 = new Ligne();
//line2.De = pp;
//line2.A = pp2;
//bool test = line.Equals(line2);
//Console.WriteLine("l1= l2 ?" + test);

//#endregion



//#region partie Linq 
//=======
//using formes.Linq;
//>>>>>>> 47906e13e71cd96bc374e799e5210919e0bf4948

//var employees = new List<Employe>
//{
//    new Employe { Id = 1, Nom= "Mohamed", DateNaissance = DateTime.Parse("1994/01/11"), Marie=true, Sex ='m',Salaire = 3333, IdDepartement =1 },
//    new Employe { Id = 2, Nom= "aymen", DateNaissance = DateTime.Parse("1955/09/19"), Marie=false, Sex ='m',Salaire = 6336, IdDepartement =2 },
//    new Employe { Id = 3, Nom= "Manel", DateNaissance = DateTime.Parse("1976/05/23"), Marie=true, Sex ='f',Salaire = 2332, IdDepartement =2 },
//    new Employe { Id = 4, Nom= "Asia", DateNaissance = DateTime.Parse("2000/11/25"), Marie=true, Sex ='f',Salaire = 4334, IdDepartement =3 },
//    new Employe { Id = 5, Nom= "Said", DateNaissance = DateTime.Parse("1991/09/30"), Marie=false, Sex ='m',Salaire = 5335, IdDepartement =3 },
//    new Employe { Id = 6, Nom= "Brahim", DateNaissance = DateTime.Parse("1988/12/31"), Marie=true, Sex ='m',Salaire = 1331, IdDepartement =2 },
//    new Employe { Id = 7, Nom= "Mohamed", DateNaissance = DateTime.Parse("2006/01/8"), Marie=false, Sex ='m',Salaire = 9339, IdDepartement =3 },

//};
//var depts = new List<Departement>
//{
//     new Departement {Id=1,Intitule="RH" },
//    new Departement {Id=2,Intitule="FC" },
//    new Departement {Id=3,Intitule="IT" },
//};

////var l1 = from x in employees where x.Salaire>5000 select x;
//var l1 = employees.Where(x => x.Salaire > 5000).Select(x => x);
//foreach (var x in l1)
//{
//    Console.WriteLine(x.Id);
//}
//Console.WriteLine("-----");

////var l2 = from x in employees where x.Marie && x.Sex=='m' select x;
//var l2 = employees.Where(x => x.Marie && x.Sex == 'm').Select(x => x);
//foreach (var x in l2)
//{
//    Console.WriteLine(x.Id);
//}
//Console.WriteLine("-----");

////var l3 = from x in employees  select new { x.Id, x.Nom};
//var l3 = employees.Select(x => new { x.Id, x.Nom });
//foreach (var x in l3)
//{
//    Console.WriteLine(x.Nom);
//}
//Console.WriteLine("-----");

////var l5 = from x in employees orderby x.Nom select x;
//var l5 = employees.OrderBy(x => x.Nom).Select(x => x);
//foreach (var x in l5)
//{
//    Console.WriteLine(x.Nom);
//}
//Console.WriteLine("-----");

////var l6 = from x in employees orderby x.Salaire descending, x.Sex select x;
//var l6 = employees.OrderByDescending(x => x.Salaire).ThenBy(x => x.Sex).Select(x => x);

//foreach (var x in l6)
//{
//    Console.WriteLine(x.Id + ":" + x.Nom + ":" + x.Salaire + ":" + x.Sex);
//}
//Console.WriteLine("-----");

////var l7 = from x in employees group x by x.IdDepartement into g select g; // ou faire comme ca 
////var l7 = from x in employees group x by x.IdDepartement into g select g select new {Departement = g.Key, Employe = g }
//var l7 = employees.GroupBy(x => x.IdDepartement).Select(g => g);
//foreach (var x in l7)
//{
//    //var dept = (from a in depts where a.Id == x.departement select a.intitule).ToArray()[0];
//    var dept = depts.Single(a => a.Id == x.Key);
//    Console.WriteLine("departement" + dept.Intitule);
//    foreach (var y in x)
//    {
//        Console.WriteLine("\t" + y.Nom);
//    }
//}
//Console.WriteLine("-----");
//var l10 = employees.OrderByDescending(x => x.DateNaissance).Select(x => x);
//foreach (var x in l10)
//{
//    Console.WriteLine(x.DateNaissance);
//}


////var l8 = from x in employees join y in depts on x.IdDepartement equals y.Id orderby y.Intitule select new {Employe = x,Departement = y};

//var l8 = employees.Join(depts, x => x.IdDepartement, y => y.Id, (x, y) => new { Employe = x, Departement = y });

//foreach (var x in l8)
//{
//    Console.WriteLine(string.Format("{0,-10}-->{1}", x.Employe.Nom, x.Departement.Intitule));
//}


//// la varieble l9 n'est pas excuter jusqua que on fait al=ppelle a elle sauf si on ajout .ToList
//var l9 = employees.Select(x => x.Sex).Distinct();
//<<<<<<< HEAD
//foreach (var x in l9)
//{
//=======
//foreach(var x in l9){
//>>>>>>> 47906e13e71cd96bc374e799e5210919e0bf4948
//    Console.WriteLine(x);
//}
//Console.WriteLine("---------");

/////en SQL les fonction vertical ou les agrégat 

//Console.WriteLine("salaire MIn :" + employees.Min(x => x.Salaire));
//Console.WriteLine("salaire Max :" + employees.Max(x => x.Salaire));
//Console.WriteLine("salaire Moyen :" + employees.Average(x => x.Salaire));
//Console.WriteLine("salaire sum :" + employees.Sum(x => x.Salaire));


//<<<<<<< HEAD
//#endregion


#region File exemple
/// le nom dans une varieble 
/// on est entrain de crée un fichier si jamais le fichier n'existe pas pour ne pas avour une erreur 
///
string chemin = "PFRO.log";
if (!File.Exists(chemin))
{ File.Create(chemin); }

///
/// readallline :  juste pour lire le fichie et chaque line il a depose dans une chaine de caractere  
///  readallline sont inconveniant est que elle vas lire est stocké tout le fichier dans le tablau de ce fairt elle prendre bcq de temps 
///  solution 'FileStram'
/// 
///
string[] lignes = File.ReadAllLines(chemin);
Console.WriteLine("debut du fichier ");
foreach (string line in lignes)
{ Console.WriteLine(line); }

Console.WriteLine("fin du fichier");
////
/// wirtealltext pour liretout le fichier puis il le depose dans une seul chaine de caractere 
/// appendeallltext  ajout a la fin du texte 
///

File.AppendAllText(chemin, "ca marche!\n"); //ajout a la fin

File.WriteAllText(chemin, "ca marche !");    // ecrase all texte
///
/// Directory est un repartoir 
///fille elle a que les methode static  cad on peut pas crée des objet 
///filleinfo qui est sealed et sont constructeur est priver par contre il y a des constructeur avec des parametre entrer qui sont pas privée a fin que on peut crée des objet 
///
/// 
/// item c'est nouvel varieble 
/// le point ! pour dire que si y a pas  dossier  il passe son chemain son erreur 
/// Getfiles  pour donner les fichier qui sont a l'interieur du dossier 
/// 
///

FileInfo file = new FileInfo(chemin);
foreach (var item in file.Directory!.GetFiles())
{ Console.WriteLine(item.Name); }



///
/// FileStream elle lit le ficher d'une manier decouper par partie 
/// 

///

FileStream fichier = new FileStream(chemin, FileMode.OpenOrCreate);

/// StreamReader il lit le fichier ( fileStream) 

StreamReader sr = new StreamReader(fichier);

///
/// Peek : es ce que il reste des charactere apres le cursseur  
///
/// on vas ajouter un try catch par mesure de securité si jamais notre programme plante et dit que le fichier est deja ouvert 
/// 

try
{
    while (sr.Peek() != -1)
    {
        Console.WriteLine((char)sr.Read());
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    ///
    /// close : liberer le fichier donc le fermer 

    /// 
    ///

    sr.Close();
    fichier.Close();
}

///
/// dans ce qui suit on vas utiliser  using  pour qu'il fait appelle a l'interface Idisposable qui est hériter par strem 
/// et cette interface utilise la methode close qui vas fermer notre fichier dans tout les cas de figure 
/// afin de liberer convenabelement les ressource 
/// cette façon de faire pour remplacer le try catch 
///

using (FileStream fichierSss = new FileStream(chemin, FileMode.OpenOrCreate))
{
    using (StreamReader srSss = new StreamReader(fichierSss))
    {
        while (srSss.Peek() != -1)
        {
            Console.WriteLine((char)srSss.Read());
        }
    }
}

///on utilise la fonction ReadAllLinesAsync  pour dire a notre programme de continuer l'execution du code en parralele 
///avec la licture de notre ficher 

var lireFichier = File.ReadAllLinesAsync(chemin);
lireFichier.ContinueWith (t => Afficher(t.Result));

void Afficher(string[] result)
{
    int i = 1;
    foreach (var line in result)
    {
        Console.WriteLine("Ligne ${0} : {1}", i++, line) ;
    }
}





#endregion


#region garbage collector
///
/// le priemer objet vas avoir un hach code differnt du deuxieme p 
/// le premier P vas etre gerer par le garbege collector par la suit 
/// 
var p = new Point { X = 5, Y = 5 };
Console.WriteLine(p.GetHashCode());
p = new Point { Y = 5, X = 5 };
Console.WriteLine(p.GetHashCode());

/// 
///  GC.Collect  c'est une methode de la class GC  qui gere la memoir et supprime les objet et variable inutilisable 
///  
/// si on veut utiliser notre 1er P avant qui soit enlever on vas utiliser un distructeur a la class point 
/// quend il rencontre un objet zombie il vas excuter un code 
/// exemple class point : 
/// 
/// GC.Collect(); supprime tous les objet dit Zombie cad no utilisable par la suite dans notre code 
///

GC.Collect();



#endregion

#region Programation Asynchron

Console.WriteLine("appelle a utility");
Utility.Afficher();
Console.WriteLine("confirmer que ca a mis 5 seconde avant de s'excuter " );

Console.WriteLine("appel asynchrone");
Utility.AfficherAsync();

Console.WriteLine("confirmer que le programe n'attent pas 5 seconde avant de s'excuter!!! ");

///
/// on vas afficher la somme de la methode somme qui est dans la class utility 
///
Console.WriteLine("calcule la somme ");
double x = Utility.Somme(5, 3);
Console.WriteLine("sync : 5+3 = {0}", x);


//Utility.AfficherAsync();

///
/// on vas afficher la somme de la methode asyncsomme qui ce trouve dans la class utility 
///

Console.WriteLine("calcule la some asynchrone");
Task<double> tache = Utility.SommeAsync(5,3);
Task task = tache.ContinueWith (t =>Console.WriteLine("async : 5+3 = {0}", t.Result));

var o = 1 + 2;
Console.WriteLine("confirmer que le programme continue {0} " , o);

Thread.Sleep(10000);

#endregion