using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_project
{
    internal abstract class AbstractAttackTool: IAttackTool
    {
        protected abstract int MAX_CAPACITY { get; }
        protected abstract int MAX_FUEL { get; }

        public int Capacity { get; private set; }
        public int Fuel { get; private set; }
        public List<string> TypesOfGoals { get; }

        public AbstractAttackTool()
        {
            Capacity = 0;
            Fuel = 0;
            TypesOfGoals = new List<string>();
        }

        public void AddCapacity(int num)
        {
            if (Capacity + num <= MAX_CAPACITY)
                Capacity += num;
        }
        public void CapacityToFull()
        {
            Capacity = MAX_CAPACITY;
        }
        public void ConsumeCapacity(int amount)
        {
            if (Capacity >= amount)
                Capacity -= amount;
        }

        public void AddFuel(int num)
        {
            if ((Fuel + num) <= MAX_FUEL)
                Fuel += num;
        }
        public void FuelToFull()
        {
            Fuel = MAX_FUEL;
        }
        public void ConsumeFuel(int amount)
        {
            if (Fuel >= amount)
                Fuel -= amount;
        }

        public void AddGoal(string goal)
        {
            TypesOfGoals.Add(goal);
        }
        public void RemoveGoal(string goal)
        {
            TypesOfGoals.Remove(goal);
        }


        public override string ToString() => $"type: {GetType().Name} | Capacity:{Capacity}, fuel: {Fuel}, Type of goals - [{ string.Join(",",TypesOfGoals)}]";
        


    }
}
