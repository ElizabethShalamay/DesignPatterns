using System.Collections.Generic;
using System.Linq;
using DesignPatternsTasks.Prototype;

namespace DesignPatternsTasks.Adapter
{
    public class QueueService : IQueueService
    {
        private IList<Queue> _queues;

        public QueueService()
        {
            _queues = new List<Queue>();
        }

        public void CreateQueue(Queue queue)
        {
            _queues.Add(queue);
        }

        public Queue GetQueueByName(string name)
        {
            return _queues.Single(queue => queue.Name == name);
        }

        public IEnumerable<Queue> GetQueuesByOrganization(string organizationName)
        {
            return _queues.Where(queue => queue.Organization.Name == organizationName);
        }
    }
}
