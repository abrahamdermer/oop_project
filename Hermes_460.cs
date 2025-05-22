using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_project
{
    internal class Hermes_460:AbstractAttackTool
    {
        protected override int MAX_CAPACITY => 3;
        protected override int MAX_FUEL => 5000;


        public Hermes_460()
        {
            TypesOfGoals.Add("Human");
            TypesOfGoals.Add("Vehicle");
        }
    }
}
