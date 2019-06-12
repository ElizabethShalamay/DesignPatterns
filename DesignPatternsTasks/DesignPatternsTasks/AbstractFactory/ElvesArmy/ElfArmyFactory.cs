using DesignPatternsTasks.AbstractFactory.Interfaces;

namespace DesignPatternsTasks.AbstractFactory.ElvesArmy
{
    public class ElfArmyFactory : IArmyFactory
    {
        public IArcher CreateArcher(string name)
        {
            return new ElfArcher(name);
        }

        public IHealer CreateHealer(string name)
        {
            return new ElfHealer(name);
        }

        public IWarrior CreateWarrior(string name)
        {
            return new ElfWarrior(name);
        }
    }
}
