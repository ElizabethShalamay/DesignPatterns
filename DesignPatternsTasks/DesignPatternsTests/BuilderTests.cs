using DesignPatternsTasks.Builder.Builder;
using DesignPatternsTasks.Builder.Models;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace DesignPatternsTests
{
    [TestFixture]
    public class BuilderTests
    {
        private IOrganizationBuilder _organizationBuilder;

        [SetUp]
        public void SetUp()
        {
            _organizationBuilder = new OrganizationBuilder();
        }

        [Test]
        public void ShouldCreateOrganizationWithSeveralDepartments()
        {
            var organizationResult = _organizationBuilder
                .WithName("Epam")
                .WithAddress("Zhylianska 75, 7th floor")
                .WithDepartment(new Department())
                .WithDepartment(new Department())
                .Build();

            organizationResult.Name.Should().Be("Epam");
            organizationResult.Address.Should().Be("Zhylianska 75, 7th floor");
            organizationResult.Departments.Should().HaveCount(2);
        }

        [Test]
        public void ShouldCreateOrganizationWithoutOptionalFields()
        {
            var organizationResult = _organizationBuilder
                .WithName("Epam")
                .Build();

            organizationResult.Name.Should().Be("Epam");
            organizationResult.Address.Should().Be(null);
            organizationResult.Departments.Should().HaveCount(0);
        }

        [Test]
        public void ShouldNotCreateOrganizationWithoutReqiredField()
        {
            Action organizationResult = () => _organizationBuilder
                .WithAddress("Zhylianska 75, 7th floor")
                .WithDepartment(new Department())
                .WithDepartment(new Department())
                .Build();

            organizationResult.Should().Throw<InvalidOperationException>();
        }

    }
}
