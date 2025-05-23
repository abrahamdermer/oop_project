﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_project
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Random random = new Random();
            Hamas hamas = new Hamas();
            IDF idf = new IDF();

            string Input ="";

            for (int i =0; i < 5; i++)
            {
                Terrorist terrorist = new Terrorist("moamd", random.Next(1, 6));
                terrorist.AddWeapon("knife");
                hamas.AddTerr(terrorist );
            }

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

            while (Input != "-1")
            {
                Input = Controler.PrintMenu();
                Controler.Activer(Input, idf);
            } 


        }
    }
}
