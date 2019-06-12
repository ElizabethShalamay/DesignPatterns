using DesignPatternsTasks.AbstractFactory.Interfaces;
using System;

namespace DesignPatternsTasks.AbstractFactory.HumanArmy
{
    public class HumanHealer : IHealer
    {
        public HumanHealer(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public Race Race => Race.Human;

        public void Heal(ISoldier target)
        {
            if (target.Race == Race)
            {
                Console.WriteLine($"Human { Name } heals { target.Name }");
            }
            else
            {
                Console.WriteLine($"{ Name } cannot heal his { target.Race.ToString().ToLower() } enemy { target.Name }");
            }
        }
    }
}
