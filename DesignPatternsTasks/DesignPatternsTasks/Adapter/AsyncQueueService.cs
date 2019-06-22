using System.Collections.Generic;
using System.Threading.Tasks;
using DesignPatternsTasks.Prototype;

namespace DesignPatternsTasks.Adapter
{
    public class AsyncQueueService : IAsyncQueueService
    {
        private readonly IQueueService _queueService;

        public AsyncQueueService(IQueueService queueService)
        {
            _queueService = queueService;
        }

        public Task CreateQueueAsync(Queue queue)
        {
            return Task.Run(() => _queueService.CreateQueue(queue));
        }

        public Task<Queue> GetQueueByNameAsync(string name)
        {
            return Task.Factory.StartNew(
                (queueName) => { return _queueService.GetQueueByName((string)queueName); }, name);
        }

        public Task<IEnumerable<Queue>> GetQueuesByOrganizationAsync(string organizationName)
        {
            return Task.Factory.StartNew(
                (name) => { return _queueService.GetQueuesByOrganization((string)name); }, organizationName);
        }
    }
}
