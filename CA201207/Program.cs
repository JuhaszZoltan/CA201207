using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA201207
{
    struct Ember
    {
        public int Szuletett { get; set; }
        public string Nev { get; set; }
    }



    class Program
    {
        static void Main()
        {
            //asszociatív tömb (C#-ban valójában lista)

            Dictionary<string, string[]> szotar = new Dictionary<string, string[]>();

            szotar.Add("dog", new string[] { "kutya", "eb", "kutyus", });
            szotar.Add("cat", new string[] { "macska", "cica", });
            szotar.Add("car", new string[] { "autó", "kocsi", "autómobil", });
            //hiba: a kulcsérték nem szerepelhet, csak egyszer
            //szotar.Add("car", new string[] { "személygépjármű", });

            foreach (KeyValuePair<string, string[]> szo in szotar)
            {
                Console.WriteLine(szo.Key + ":");
                foreach (var m in szo.Value)
                {
                    Console.WriteLine("\t" + m);
                }
            }

            Console.WriteLine("-----------------------");

            foreach (var m in szotar["cat"])
            {
                Console.WriteLine(m);
            }

            Console.WriteLine("-----------------------");
            szotar["car"] = new string[] { "autó", "kocsi", "autómobil", "személygépjármű", };

            foreach (var m in szotar["car"])
            {
                Console.WriteLine(m);
            }

            Console.WriteLine("-----------------------");

            foreach (var kulcs in szotar.Keys)
            {
                Console.WriteLine(kulcs);
            }

            Console.WriteLine("-----------------------");

            foreach (var ertek in szotar.Values)
            {
                foreach (var m in ertek)
                {
                    Console.WriteLine(m);
                }
            }

            var lista = new List<Ember>()
            {
                new Ember() { Szuletett = 2000, Nev = "Géza" },
                new Ember() { Szuletett = 2004, Nev = "Feri" },
                new Ember() { Szuletett = 2000, Nev = "Laci" },
                new Ember() { Szuletett = 2002, Nev = "zoli" },
                new Ember() { Szuletett = 2000, Nev = "józsi" },
                new Ember() { Szuletett = 1997, Nev = "réka" },
                new Ember() { Szuletett = 2002, Nev = "evelin" },
                new Ember() { Szuletett = 2002, Nev = "béla" },
                new Ember() { Szuletett = 2000, Nev = "ádám" },
                new Ember() { Szuletett = 2001, Nev = "tamás" },
                new Ember() { Szuletett = 2000, Nev = "endre" },
            };

            var dic = new Dictionary<int, int>();

            foreach (var ember in lista)
            {
                if(!dic.Keys.Contains(ember.Szuletett))
                {
                    dic.Add(ember.Szuletett, 1);
                }
                else
                {
                    dic[ember.Szuletett]++;
                }
            }


            foreach (var ev in dic)
            {
                Console.WriteLine($"{ev.Key}: {ev.Value}");
            }


            var rendezett = dic.OrderBy(x => x.Key);

            foreach (var item in rendezett)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey(true);
        }
    }
}
