using System.Collections.Generic;

namespace DesignPatternsTasks.FactoryMethod
{
    public interface IQueueManager
    {
        List<Queue> Queues { get; set; }

        void Enqueue(string queueName, string userName);

        void DisplayQueue(string queue);

        void DisplayQueue(Queue queue);

        Queue CreateQueue(QueueType queueType);
    }
}
