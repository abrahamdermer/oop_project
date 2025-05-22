using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_project
{
    internal class Artillery560M:AbstractAttackTool
    {
        protected override int MAX_CAPACITY => 40;
        protected override int MAX_FUEL => 0;


        public Artillery560M()
        {
            TypesOfGoals.Add("Human");
            TypesOfGoals.Add("Vehicle");
        }
    }
}
