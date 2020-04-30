using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvancedCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Créer delegate qui va pointer sur DelegateEx2Atelier5.Addition()
            BinaryOp bop = new BinaryOp(DelegateEx2Atelier5.Addition);

            //Invoquer Addition()
            Console.WriteLine(bop(10,20));
            //Créer une liste générique de type Personne
            List<Personne> p = new List<Personne>()
            {
                new Personne() {Id = 1, age = 20, Name="aaa" },
                new Personne() {Id = 2, age = 16, Name="aaa" },
                new Personne() {Id = 3, age = 14, Name="bbbb" },

            };
            //Retourner les persoones ayant age <15 & >20
            //Deffered Query
            //DotNotation Syntax
            var PersonList = p.Where(a => a.age > 15 && a.age < 20).ToList();
            //Récupérer la 1ere personne ayant comme nom "aaa"
            var Person = p.Where(a => a.Name == "aaa").FirstOrDefault();
            //Récupérer la personne ayant comme id = 2
            var Personne = p.SingleOrDefault(c=> c.Id == 2);

            int[] numbers = { 1, 4, 6, 8, 10, 12 };
            //Utiliser LINQ query pour récupérer les entiers supérieur à 6???
            //Query Syntax
            var res = from i in numbers where i < 6 select i;

            foreach(var item in res)
            {
                Console.WriteLine(item);
            }
            //Exemple working with string
            //1. String
            string s1 = "bla bla bla";
            s1 = s1 + ".....";
            StringBuilder sb = new StringBuilder("bla bla bla");
            sb.Append("....");
            //Exercice 2 Q1
            //Définir et initialiser (Init Syntax) une liste générique de points
            List<Point> pointList = new List<Point>
            {
                new Point { X = 2, Y = 10},
                new Point { X = 5, Y = 6},
                new Point { X = 7, Y = 8}
            };
            //afficher le résultat
            foreach (var item in pointList)
            {
                Console.WriteLine(item);
            }
            //Exercice 2 Q2
            List<Rectangle> rectangList = new List<Rectangle>
            {
                new Rectangle {TopLeft = new Point { X = 1, Y = 2 },
                BottomRight = new Point { X = 3, Y = 4 } },
                new Rectangle {TopLeft = new Point { X = 5, Y = 6 },
                BottomRight = new Point { X = 3, Y = 7 } }
            };
            //Affichage
            foreach(var item in rectangList)
            {
                Console.WriteLine(item);
            }
            //Exercice 1
            ArrayList arrayList = new ArrayList();
            arrayList.AddRange(new string[] { "A", "B", "C", "D"});
            //Affichage nombre d'élèments du ArrayList
            Console.WriteLine("Le nombre d'éléments dans la collection est {0}", arrayList.Count);
            arrayList.Add("E");
            Console.WriteLine("Le nombre d'éléments dans la collection est {0}", arrayList.Count);
            //Itérer à l'intérieur de arrayList à l'aide du Foreach
            foreach(string item in arrayList)
            {
                Console.WriteLine(item);
            }
            //Déclarer une Liste de voitures de type Generic
            List<string> voitures = new List<string>();
            voitures.Add("Mercedes");
            voitures.Add("BMW");
            voitures.Add("Ford");
            //Je peux utiliser enumération (foreach) étant donnée que je travaille avec une liste 
            foreach(var item in voitures)
            {
                Console.WriteLine(item);
            }

            IList<int> list2 = new List<int>();
            list2.Add(5);
            list2.Add(10);
            //list2.Add("Hello");
            Console.WriteLine("Non Generic Types");
            
            foreach (int x in list2)
            {
                Console.WriteLine(x);
            }
            voiture v = new voiture();
            v[0] = "dddd";
            v[1] = "aaaa";
            v[2] = "cccc";
            foreach(var item in v)
            {
                Console.WriteLine(item);
            }
        }
    }
    public class voiture : IEnumerable
    {
        string[] car = new string[3];
        
        //Indexer -> méthode spécifique qui se comporte comme une collection
        //Possibilité de créer des Indexers à partir de classes, structures, etc..
        public string this[int Num]
        {
            get { return car[Num]; }
            set { car[Num] = value; }
        }

        //Créer notre propre itérateur en utilisant Yield
        public IEnumerator GetEnumerator()
        {
           foreach(var s in car)
            {
                yield return s;
            }
        }
    }
}
