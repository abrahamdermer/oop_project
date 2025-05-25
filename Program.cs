using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace oop_project
{
    internal class Program
    {
       
        private static void Create10Terrorists(Hamas hamas)
        {
            Random random = new Random();
            string[] names = new string[] { "Muhammad", "Ahmad", "Ali", "Omar", "Yassin", "Fatima", "Layla" };
            string[] weapons = new string[] { "Knife", "Pistol", "MK47","M16", "RPG" };
            for (int i = 0; i < 5; i++)
            {
                Terrorist terrorist = new Terrorist(names[random.Next(names.Length)], random.Next(1, 6));
                for (int y=0;y<3;y++)
                    terrorist.AddWeapon(weapons[random.Next(weapons.Length)]);
                hamas.AddTerr(terrorist);
            }
        }
        
        static void Main(string[] args)
        {
            Random random = new Random();
            Hamas hamas = new Hamas();
            IDF idf = new IDF();

            string Input ="";

            Create10Terrorists(hamas);

            F16_Plane f16_Plane_1 = new F16_Plane();
            f16_Plane_1.CapacityToFull();
            f16_Plane_1.FuelToFull();
            idf.Arms.Add(f16_Plane_1);

            Hermes_460 hermes_460_1 = new Hermes_460();
            hermes_460_1.CapacityToFull();
            hermes_460_1.FuelToFull();
            idf.Arms.Add(hermes_460_1);

            Artillery560M artillery560M = new Artillery560M();
            artillery560M.CapacityToFull();
            idf.Arms.Add(artillery560M);



            Terrorist machbel1 = new Terrorist("moand", 3);
            IntelligenceAlert alert1 = new IntelligenceAlert(machbel1,"Home",new DateTime(2000,01,01));
            idf.Alerts.Add(alert1);

            for (int i = 0; i < 20; i++)
            {
                idf.Alerts.Add(new IntelligenceAlert(hamas.arms[random.Next(hamas.arms.Count)],"Home",DateTime.Today));
            }

            while (Input != "-1")
            {
                Input = Controler.PrintMenu();
                Controler.Activer(Input, idf,hamas);
            } 


        }
    }
}
