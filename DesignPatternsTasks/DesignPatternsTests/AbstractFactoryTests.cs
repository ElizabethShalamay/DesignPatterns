using Autofac;
using DesignPatternsTasks.AbstractFactory;
using DesignPatternsTasks.AbstractFactory.DwarfsArmy;
using DesignPatternsTasks.AbstractFactory.ElvesArmy;
using DesignPatternsTasks.AbstractFactory.HumanArmy;
using DesignPatternsTasks.AbstractFactory.Interfaces;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Linq;

namespace DesignPatternsTests
{
    [TestFixture]
    public class AbstractFactoryTests
    {
        private IComponentContext _context;
        private IArmyFactory _armyFactory;

        [SetUp]
        public void Setup()
        {
            _context = ArmyModule.BuildContainer();
        }

        [TestCase(Race.Dwarf, typeof(DwarfArcher), typeof(DwarfHealer), typeof(DwarfWarrior))]
        [TestCase(Race.Elf, typeof(ElfArcher), typeof(ElfHealer), typeof(ElfWarrior))]
        [TestCase(Race.Human, typeof(HumanArcher), typeof(HumanHealer), typeof(HumanWarrior))]
        public void ShouldCreateDwarfArmy(Race race, Type acherType, Type healerType, Type warriorType)
        {
            _armyFactory = _context.ResolveKeyed<IArmyFactory>(race);
            var army = new Army(_armyFactory);

            army.CreateArmy(1, 1, 1);

            army.Archers.First().Should().BeOfType(acherType);
            army.Healers.First().Should().BeOfType(healerType);
            army.Warriors.First().Should().BeOfType(warriorType);
        }
    }
}
