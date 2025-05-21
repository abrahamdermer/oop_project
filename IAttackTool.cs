using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_project
{
    internal interface IAttackTool
    {
        int Capacity { get; }
        int Fuel { get; }
        List<string> TypesOfGoals { get; }

        void AddCapacity(int num);
        void CapacityToFull();
        void ConsumeCapacity(int amount);

        void AddFuel(int num);
        void FuelToFull();
        void ConsumeFuel(int amount);

        void AddGoal(string goal);
        void RemoveGoal(string goal);


    }
}
