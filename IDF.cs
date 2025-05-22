using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_project
{
    internal class IDF
    {
        public DateTime Foundation { get; } = new DateTime(1948, 05, 26);
        public string commander => "Eyal Zamir" ;
        public List<AbstractAttackTool> arms { get; } = new List<AbstractAttackTool>();


    }
}
