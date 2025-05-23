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
            Weapons.Add(weapon);
        }


        public string Tostring() => $"name:{Name}, ";

    }
}
