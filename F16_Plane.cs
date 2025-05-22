using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_project
{
    internal class F16_Plane : AbstractAttackTool
    {
        protected override int MAX_CAPACITY => 8 ;
        protected override int MAX_FUEL => 1000;


        public F16_Plane()
        {
            TypesOfGoals.Add("Buildings");
        }
    }
}
