using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_project
{
    internal class Terrorist
    {
        private const int DEFAULT_RANK = 1;
        private const int MAX_RANK = 5;
        private const int MIN_RANK = 1;
        public string Name { get; set; }
        public int Rank { get; private set; }
        public bool InLive { get; private set; }
        public List<string> Weapons { get; private set; }
        public int RiskRating { get; private set; } = 0;


        public  Terrorist(string name , int rank)
        {
            Name = name;
            if (rank <= MAX_RANK && rank >= MIN_RANK)
                Rank = rank;
            else
                Rank = DEFAULT_RANK;
            InLive = true;
            Weapons = new List<string>();

        }

        public void SetRank(int newRank)
        {
            if (newRank <= MAX_RANK && newRank >= MIN_RANK)
                Rank = newRank;
        }

        public void MarkAsDead()
        {
            InLive = false;
        }

        public void AddWeapon(string weapon)
        {
            switch (weapon)
            {
                case "Knife":
                    RiskRating += 1* Rank;
                    Weapons.Add(weapon);
                    break;
                case "Pistol":
                    RiskRating += 2 * Rank;
                    Weapons.Add(weapon);
                    break;
                case "MK47":
                    RiskRating += 3 * Rank;
                    Weapons.Add(weapon);
                    break;
                case "M16":
                    RiskRating += 3 * Rank;
                    Weapons.Add(weapon);
                    break;
                case "RPG":
                    RiskRating += 4 * Rank;
                    Weapons.Add(weapon);
                    break;
            }
        }


        public  override string ToString() => $"name: {Name} | Rick rating: {RiskRating}, Rank: {Rank},";

    }
}
