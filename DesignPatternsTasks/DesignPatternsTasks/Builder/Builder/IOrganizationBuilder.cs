using DesignPatternsTasks.Builder.Models;

namespace DesignPatternsTasks.Builder.Builder
{
    public interface IOrganizationBuilder
    {
        IOrganizationBuilder WithName(string name);
        IOrganizationBuilder WithAddress(string address);
        IOrganizationBuilder WithDepartment(Department department);
        Organization Build();
    }
}
