using DesignPatternsTasks.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsTasks.AbstractFactory.HumanArmy
{
    public class HumanArcher : IArcher
    {
        public HumanArcher(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public Race Race => Race.Human;

        public void Shoot(ISoldier target)
        {
            if (target.Race != Race)
            {
                Console.WriteLine($"Human { Name } shoots { target.Name }");
            }
            else
            {
                Console.WriteLine($"{ Name } cannot shoot his human friend { target.Name }");
            }
        }
    }
}
