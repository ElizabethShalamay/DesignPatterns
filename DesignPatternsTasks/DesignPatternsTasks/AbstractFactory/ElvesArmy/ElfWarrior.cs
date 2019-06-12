using DesignPatternsTasks.AbstractFactory.Interfaces;
using System;

namespace DesignPatternsTasks.AbstractFactory.ElvesArmy
{
    public class ElfWarrior : IWarrior
    {
        public ElfWarrior(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public Race Race => Race.Elf;

        public void Hit(ISoldier target)
        {
            if (target.Race != Race)
            {
                Console.WriteLine($"Elf { Name } hits { target.Name }");
            }
            else
            {
                Console.WriteLine($"{ Name } cannot hit his elf friend { target.Name }");
            }
        }
    }
}
