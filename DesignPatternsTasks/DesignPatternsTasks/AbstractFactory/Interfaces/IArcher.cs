namespace DesignPatternsTasks.AbstractFactory.Interfaces
{
    public interface IArcher : ISoldier
    {
        void Shoot(ISoldier target);
    }
}
