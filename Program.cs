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



        //private static void Create10Terrorists(Hamas hamas)
        //{
        //    Random random = new Random();
        //    string[] names = new string[] { "Muhammad", "Ahmad", "Ali", "Omar", "Yassin", "Fatima", "Layla" };
        //    WeaponsTypes[] weapons = (WeaponsTypes[])Enum.GetValues(typeof(WeaponsTypes));

        //    for (int i = 0; i < 5; i++)
        //    {
        //        Terrorist terrorist = new Terrorist(names[random.Next(names.Length)], random.Next(1, 6));
        //        int num_wea = random.Next(3);
        //        for (int y=0;y<num_wea;y++)
        //            terrorist.AddWeapon(weapons[random.Next(weapons.Length)]);
        //        hamas.AddTerr(terrorist);
        //    }
        //}

        //private static void CreateAllAttackTools(IDF idf)
        //{
        //    F16_Plane f16_Plane_1 = new F16_Plane();
        //    f16_Plane_1.CapacityToFull();
        //    f16_Plane_1.FuelToFull();
        //    idf.Arms.Add(f16_Plane_1);

        //    Hermes_460 hermes_460_1 = new Hermes_460();
        //    hermes_460_1.CapacityToFull();
        //    hermes_460_1.FuelToFull();
        //    idf.Arms.Add(hermes_460_1);

        //    Artillery560M artillery560M = new Artillery560M();
        //    artillery560M.CapacityToFull();
        //    idf.Arms.Add(artillery560M);

        //}

        //private static void Create20Alerts(IDF idf,Hamas hamas)
        //{
        //    Random random = new Random();
        //    for (int i = 0; i < 20; i++)
        //    {
        //        idf.Alerts.Add(new IntelligenceAlert(hamas.arms[random.Next(hamas.arms.Count)], "Home", DateTime.Today));
        //    }
        //}

        static async Task Main(string[] args)
        {
            await TestAPI.CallGeminiAsync();

            //    Random random = new Random();
            //    Hamas hamas = new Hamas();
            //    IDF idf = new IDF();

            //    string Input ="";

            //    Create10Terrorists(hamas);

            //    CreateAllAttackTools(idf);

            //    Create20Alerts(idf, hamas);

            //    while (Input != "-1")
            //    {
            //        Input = Controler.PrintMenu();
            //        Controler.Activer(Input, idf,hamas);
        }


        //}
    }
}
