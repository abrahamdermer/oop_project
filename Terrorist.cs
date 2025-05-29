using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_project
{
    enum WeaponsTypes { Knife, Pistol , MK47 , M16 = 2 , RPG = 3 }
    internal class Terrorist
    {
        private const int DEFAULT_RANK = 1;
        private const int MAX_RANK = 5;
        private const int MIN_RANK = 1;
        public string Name { get; set; }
        public int Rank { get; private set; }
        public bool InLive { get; private set; }
        public List<WeaponsTypes> Weapons { get; private set; }
        public int RiskRating => RiskPoints * Rank;

        private int RiskPoints = 0;


        public  Terrorist(string name , int rank)
        {
            Name = name;
            if (rank <= MAX_RANK && rank >= MIN_RANK)
                Rank = rank;
            else
                Rank = DEFAULT_RANK;
            InLive = true;
            Weapons = new List<WeaponsTypes>();

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

        public void AddWeapon(WeaponsTypes weapon)
        {
            Weapons.Add(weapon);
            RiskPoints += (int)weapon +1;
        }


        public  override string ToString() => $"name: {Name} | Rick rating: {RiskRating}, Rank: {Rank},";

    }
}
