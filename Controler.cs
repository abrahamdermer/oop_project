using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_project
{
    internal static class Controler
    {
        public static string  PrintMenu()
        {
            string input;
           
            Console.WriteLine("Please enter your choice:" +
                "\n1 - Show the terrorist with the most reports" +
                "\n2 - Display available attack tools" +
                "\n3 - Show the highest-ranked terrorist" +
                "\n4 - Issue attack command" +
                "\n-1 - Exit"
                );

            input = Console.ReadLine();
            return input;
        }

        public static void Activer(string input,IDF idf,Hamas hamas)
        {
            switch (input)
            {
                case "1":
                    Terrorist ter = Analyzer.GetMostCommonTerrorist(idf.Alerts);
                    Console.WriteLine((ter != null ? ter.ToString():"null"));
                    break;
                case "2":
                    foreach(IAttackTool tool in idf.Arms)
                    {
                        Console.WriteLine(tool.ToString());
                    }
                    break;
                case "3":
                    Terrorist ter2 = Analyzer.GetPreferredTerrorist(hamas.arms);
                    Console.WriteLine((ter2 != null ? ter2.ToString() : "null"));
                    break;
                case "4":
                    break;
            }
        }
    }
}
