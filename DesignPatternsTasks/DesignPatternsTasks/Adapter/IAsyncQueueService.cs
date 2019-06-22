using DesignPatternsTasks.Prototype;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternsTasks.Adapter
{
    public interface IAsyncQueueService
    {
        Task<Queue> GetQueueByNameAsync(string name);
        Task<IEnumerable<Queue>> GetQueuesByOrganizationAsync(string organizationName);
        Task CreateQueueAsync(Queue queue);
    }
}
