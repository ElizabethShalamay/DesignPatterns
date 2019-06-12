using DesignPatternsTasks.AbstractFactory.Interfaces;
using System;

namespace DesignPatternsTasks.AbstractFactory.ElvesArmy
{
    public class ElfHealer : IHealer
    {
        public ElfHealer(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public Race Race => Race.Elf;

        public void Heal(ISoldier target)
        {
            if (target.Race == Race)
            {
                Console.WriteLine($"Elf { Name } heals { target.Name }");
            }
            else
            {
                Console.WriteLine($"{ Name } cannot heal his { target.Race.ToString().ToLower() } enemy { target.Name }");
            }
        }
    }
}
