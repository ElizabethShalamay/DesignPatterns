using System;
using DesignPatternsTasks.Builder.Models;

namespace DesignPatternsTasks.Builder.Builder
{
    public class OrganizationBuilder : IOrganizationBuilder
    {
        private Organization _organization;

        public OrganizationBuilder()
        {
            _organization = new Organization();
        }

        public Organization Build()
        {
            if(string.IsNullOrEmpty(_organization.Name))
            {
                throw new InvalidOperationException($"Required fields are not filled: {nameof(_organization.Name)}");
            }

            return _organization;
        }

        public IOrganizationBuilder WithAddress(string address)
        {
            _organization.Address = address;
            return this;
        }

        public IOrganizationBuilder WithDepartment(Department department)
        {
            _organization.Departments.Add(department);
            return this;
        }

        public IOrganizationBuilder WithName(string name)
        {
            _organization.Name = name;
            return this;
        }
    }
}
