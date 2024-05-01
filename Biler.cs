using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolboxH1
{
    internal class Biler
    {
        string name;
        int rpm;
        string color;
        int speed;


        public string Name { get => name; set => name = value; }
        public int RPM { get => rpm; set => rpm = value; }
        public string Color { get => color; set => color = value; }
        public int Speed { get => speed; set => speed = value; }


        public Biler(string name, int rPM, string color, int speed)
        {
            Name = name;
            RPM = rPM;
            Color = color;
            Speed = speed;
        }

        public Biler()
        {
        }

        public static void PrintCars()
        {
            List<Biler> bilListe = new List<Biler>();
            bilListe.Add(new Biler("Wimmer GT2 RS", 7000, "Blå", 389));
            bilListe.Add(new Biler("Abt R8 GTR", 8000, "Rød", 325));
            bilListe.Add(new Biler("Techart GTstreet R", 6500, "Gul", 352));

            //sorteret med IComparer
            bilListe.Sort(new Datatypes(SortBy.RPM));

            foreach (var item in bilListe)
            {
                Console.WriteLine(item);
            }
        }

        public override string? ToString()
        {
            return $"Bilmærke: {Name}, \nFarve: {Color}, \nRPM: {RPM}, \nFart: {Speed}\n";
        }
    }
}
