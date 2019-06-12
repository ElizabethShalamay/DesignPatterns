using DesignPatternsTasks.AbstractFactory.Interfaces;
using System;

namespace DesignPatternsTasks.AbstractFactory.DwarfsArmy
{
    public class DwarfArcher : IArcher
    {
        public DwarfArcher(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public Race Race => Race.Dwarf;

        public void Shoot(ISoldier target)
        {
            if (target.Race != Race)
            {
                Console.WriteLine($"Dwarf { Name } shoots { target.Name }");
            }
            else
            {
                Console.WriteLine($"{ Name } cannot shoot his dwarf friend { target.Name }");
            }
        }
    }
}
