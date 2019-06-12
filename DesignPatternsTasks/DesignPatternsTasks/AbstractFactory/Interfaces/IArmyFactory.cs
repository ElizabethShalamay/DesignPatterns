namespace DesignPatternsTasks.AbstractFactory.Interfaces
{
    public interface IArmyFactory
    {
        IArcher CreateArcher(string name);
        IHealer CreateHealer(string name);
        IWarrior CreateWarrior(string name);
    }
}
