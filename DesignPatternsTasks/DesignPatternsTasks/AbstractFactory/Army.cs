using DesignPatternsTasks.AbstractFactory.Interfaces;
using System.Collections.Generic;

namespace DesignPatternsTasks.AbstractFactory
{
    public class Army : IArmy
    {
        private IArmyFactory _armyFactory;

        public IList<IArcher> Archers { get; set; }
        public IList<IHealer> Healers { get; set; }
        public IList<IWarrior> Warriors { get; set; }

        public Army(IArmyFactory armyFactory)
        {
            _armyFactory = armyFactory;
            Archers = new List<IArcher>();
            Healers = new List<IHealer>();
            Warriors = new List<IWarrior>();
        }

        public void CreateArmy(int archersNumber, int healersNumber, int warriorsNumber)
        {
            for(int i = 0; i < archersNumber; i++)
            {
                Archers.Add(_armyFactory.CreateArcher($"Archer {i + 1}"));
            }
            for (int i = 0; i < healersNumber; i++)
            {
                Healers.Add(_armyFactory.CreateHealer($"Healer {i + 1}"));
            }
            for (int i = 0; i < warriorsNumber; i++)
            {
                Warriors.Add(_armyFactory.CreateWarrior($"Warrior {i + 1}"));
            }
        }
    }
}
