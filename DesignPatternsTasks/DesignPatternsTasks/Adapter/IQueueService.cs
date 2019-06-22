using DesignPatternsTasks.Prototype;
using System.Collections.Generic;

namespace DesignPatternsTasks.Adapter
{
    public interface IQueueService
    {
        Queue GetQueueByName(string name);
        IEnumerable<Queue> GetQueuesByOrganization(string organizationName);
        void CreateQueue(Queue queue);
    }
}
