namespace DesignPatternsTasks.AbstractFactory.Interfaces
{
    public interface IHealer : ISoldier
    {
        void Heal(ISoldier target);
    }
}
