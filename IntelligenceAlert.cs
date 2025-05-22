using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_project
{
    internal class IntelligenceAlert
    {
        public Terrorist Terrorist { get; }
        public string Location { get; }
        public DateTime Time { get; }

        public IntelligenceAlert(Terrorist terrorist,string location, DateTime time)
        {
            Terrorist = terrorist;
            Location = location;
            Time = time;
        }


    }
}
