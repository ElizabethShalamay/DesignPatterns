using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatternsTasks.FactoryMethod
{
    public class QueueManager : IQueueManager
    {
        private IComponentContext _context;
        public List<Queue> Queues { get; set; }

        public QueueManager()
        {
            Queues = new List<Queue>();
        }

        public QueueManager(IComponentContext context)
        {
            _context = context;
            Queues = new List<Queue>();
        }

        //// 1
        //public Queue CreateQueue(QueueType queueType)
        //{
        //    switch (queueType)
        //    {
        //        case QueueType.Default:
        //            return new DefaultQueue();
        //        case QueueType.Advanced:
        //            return new AdvancedQueue();
        //        default:
        //            throw new ArgumentException();
        //    }
        //}


        //// 2
        //public Queue CreateQueue(QueueType queueType)
        //{
        //    Type type = Type.GetType($"DesignPatternsTasks.FactoryMethod. {queueType.ToString() }Queue");
        //    return (Queue)Activator.CreateInstance(type);
        //}

        //// 3
        public Queue CreateQueue(QueueType queueType)
        {
            return _context.ResolveKeyed<Queue>(queueType);
        }

        public void DisplayQueue(string queueName)
        {
            var queue = Queues.SingleOrDefault(q => q.Name == queueName);
            if (queue != null)
            {
                DisplayInternal(queue);
                return;
            }

            NotifyQueueWasNotFound(queueName);
        }

        public void DisplayQueue(Queue queue)
        {
            DisplayInternal(queue);
        }

        public void Enqueue(string queueName, string userName)
        {
            var queue = Queues.SingleOrDefault(q => q.Name == queueName);

            if (queue != null)
            {
                queue.Enqueue(userName);
                return;
            }

            NotifyQueueWasNotFound(queueName);
        }

        private void DisplayInternal(Queue queue)
        {
            var queuePartisipants = string.Join(", ", queue.Users);

            Console.WriteLine($"Queue { queue.Name } ({ queue.QueueType.ToString().ToLower() }) contains { queue.Users.Count } partisipants: { queuePartisipants }");
        }

        private void NotifyQueueWasNotFound(string queueName)
        {
            Console.WriteLine($"Queue {queueName} was not found.");
        }
    }
}
