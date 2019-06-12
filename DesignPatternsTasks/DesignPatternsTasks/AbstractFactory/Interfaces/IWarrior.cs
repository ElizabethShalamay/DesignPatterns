namespace DesignPatternsTasks.AbstractFactory.Interfaces
{
    public interface IWarrior : ISoldier
    {
        void Hit(ISoldier target);
    }
}
