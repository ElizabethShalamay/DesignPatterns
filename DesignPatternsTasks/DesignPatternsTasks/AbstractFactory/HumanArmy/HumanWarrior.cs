using DesignPatternsTasks.AbstractFactory.Interfaces;
using System;

namespace DesignPatternsTasks.AbstractFactory.HumanArmy
{
    public class HumanWarrior : IWarrior
    {
        public HumanWarrior(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public Race Race => Race.Human;

        public void Hit(ISoldier target)
        {
            if (target.Race != Race)
            {
                Console.WriteLine($"Human { Name } hits { target.Name }");
            }
            else
            {
                Console.WriteLine($"{ Name } cannot hit his human friend { target.Name }");
            }
        }
    }
}
