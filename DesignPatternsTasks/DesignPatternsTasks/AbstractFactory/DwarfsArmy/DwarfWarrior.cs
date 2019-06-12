using DesignPatternsTasks.AbstractFactory.Interfaces;
using System;

namespace DesignPatternsTasks.AbstractFactory.DwarfsArmy
{
    public class DwarfWarrior : IWarrior
    {
        public DwarfWarrior(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public Race Race => Race.Dwarf;

        public void Hit(ISoldier target)
        {
            if (target.Race != Race)
            {
                Console.WriteLine($"Dwarf { Name } hits { target.Name }");
            }
            else
            {
                Console.WriteLine($"{ Name } cannot hit his dwarf friend { target.Name }");
            }
        }
    }
}
