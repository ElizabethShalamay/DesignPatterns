using DesignPatternsTasks.AbstractFactory.Interfaces;
using System;

namespace DesignPatternsTasks.AbstractFactory.DwarfsArmy
{
    public class DwarfHealer : IHealer
    {
        public DwarfHealer(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public Race Race => Race.Dwarf;

        public void Heal(ISoldier target)
        {
            if (target.Race == Race)
            {
                Console.WriteLine($"Dwarf { Name } heals { target.Name }");
            }
            else
            {
                Console.WriteLine($"{ Name } cannot heal his { target.Race.ToString().ToLower() } enemy { target.Name }");
            }
        }
    }
}
