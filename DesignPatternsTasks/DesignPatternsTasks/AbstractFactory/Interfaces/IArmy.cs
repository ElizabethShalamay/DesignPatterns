using System.Collections.Generic;

namespace DesignPatternsTasks.AbstractFactory.Interfaces
{
    public interface IArmy
    {
        IList<IArcher> Archers { get; set; }
        IList<IHealer> Healers{ get; set; }
        IList<IWarrior> Warriors{ get; set; }

        void CreateArmy(int archersNumber, int healersNumber, int warriorsNumber);
    }
}
