using DesignPatternsTasks.AbstractFactory.Interfaces;

namespace DesignPatternsTasks.AbstractFactory.HumanArmy
{
    public class HumanArmyFactory : IArmyFactory
    {
        public IArcher CreateArcher(string name)
        {
            return new HumanArcher(name);
        }

        public IHealer CreateHealer(string name)
        {
            return new HumanHealer(name);
        }

        public IWarrior CreateWarrior(string name)
        {
            return new HumanWarrior(name);
        }
    }
}
