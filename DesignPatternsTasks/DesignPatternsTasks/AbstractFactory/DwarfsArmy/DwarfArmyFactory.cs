using DesignPatternsTasks.AbstractFactory.Interfaces;

namespace DesignPatternsTasks.AbstractFactory.DwarfsArmy
{
    public class DwarfArmyFactory : IArmyFactory
    {
        public IArcher CreateArcher(string name)
        {
            return new DwarfArcher(name);
        }

        public IHealer CreateHealer(string name)
        {
            return new DwarfHealer(name);
        }

        public IWarrior CreateWarrior(string name)
        {
            return new DwarfWarrior(name);
        }
    }
}
