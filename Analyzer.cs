using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_project
{
    internal static class Analyzer
    {
        public static Terrorist GetMostCommonTerrorist(List<IntelligenceAlert> alerts)
        {
            if (alerts.Count <= 0)
                return null;
            Dictionary<Terrorist, int> dic = new Dictionary<Terrorist, int>();
            foreach(IntelligenceAlert alert in alerts)
            {
                if (dic.ContainsKey(alert.Terrorist))
                    dic[alert.Terrorist] += 1;
                else dic[alert.Terrorist] = 1;
            }

            Terrorist terrorist = alerts[0].Terrorist;
            int num = 0;
            foreach (var ter in dic)
            {
                if (ter.Value > num)
                {
                    terrorist = ter.Key;
                    num = ter.Value;
                }
            }
            return terrorist ;
        }



        public static Terrorist GetPreferredTerrorist(List<Terrorist> terrorists)
        {
            if (terrorists.Count < 1)
                return null;
            Terrorist terrorist = terrorists[0];
            int maxRating = terrorist.RiskRating;
            foreach (Terrorist ter in terrorists)
            {
                if(ter.RiskRating > maxRating)
                {
                    terrorist = ter;
                    maxRating = ter.RiskRating;
                }
            }
            return terrorist;
        }
    }
}
