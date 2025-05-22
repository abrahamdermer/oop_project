using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_project
{
    internal class Hamas
    {
        public DateTime Foundation { get; } = new DateTime(1978,12,10);
        public Terrorist commander { get; } = new Terrorist("efg" ,5);
        public List<Terrorist> arms = new List<Terrorist>();


        public void AddTerr(Terrorist ter)
        {
            arms.Add(ter);
        }
    }
}

