using DesignPatternsTasks.AbstractFactory.Interfaces;
using System;

namespace DesignPatternsTasks.AbstractFactory.ElvesArmy
{
    public class ElfArcher : IArcher
    {
        public ElfArcher(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public Race Race => Race.Elf;

        public void Shoot(ISoldier target)
        {
            if (target.Race != Race)
            {
                Console.WriteLine($"Elf { Name } shoots { target.Name }");
            }
            else
            {
                Console.WriteLine($"{ Name } cannot shoot his elf friend { target.Name }");
            }
        }
    }
}
