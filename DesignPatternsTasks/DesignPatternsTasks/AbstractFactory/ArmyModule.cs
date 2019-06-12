using Autofac;
using DesignPatternsTasks.AbstractFactory.DwarfsArmy;
using DesignPatternsTasks.AbstractFactory.ElvesArmy;
using DesignPatternsTasks.AbstractFactory.HumanArmy;
using DesignPatternsTasks.AbstractFactory.Interfaces;

namespace DesignPatternsTasks.AbstractFactory
{
    public class ArmyModule : Module
    {
        public static IComponentContext BuildContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<DwarfArmyFactory>().Keyed<IArmyFactory>(Race.Dwarf);
            builder.RegisterType<ElfArmyFactory>().Keyed<IArmyFactory>(Race.Elf);
            builder.RegisterType<HumanArmyFactory>().Keyed<IArmyFactory>(Race.Human);

            return builder.Build();
        }
    }
}

