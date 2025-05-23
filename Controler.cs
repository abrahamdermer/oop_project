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
           
            Console.WriteLine("תכניס את הבחירה שלך:" +
            "\n1 בשביל לקבל את המחבל עם הכי הרבה דוחות" +
            "\n2 לקבלת אפשרויות תקיפה זמינות" +
            "\n3 המחבל אם הדרוג הגבוה ביותר\n4 פקודת תקיפה " +
            "\n-1 exit");

            input = Console.ReadLine();
            return input;
        }

        public static void Activer(string input,IDF idf)
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
                    break;
                case "4":
                    break;
            }
        }
    }
}
