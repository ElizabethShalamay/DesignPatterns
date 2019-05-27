using Autofac;
using DesignPatternsTasks.FactoryMethod;
using System;

namespace DesignPatternsTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = FactoryModule.BuildContainer();

            var manager = container.Resolve<IQueueManager>();

            var defaultQueue = manager.CreateQueue(QueueType.Default);
            // var defaultQueue = DefaultQueue.CreateQueue();

            defaultQueue.Name = "Queue 1";
            manager.Queues.Add(defaultQueue);

            manager.Enqueue(defaultQueue.Name, "Peter");
            manager.Enqueue(defaultQueue.Name, "Jane");
            manager.Enqueue(defaultQueue.Name, "Marie");


            var advancedQueue = manager.CreateQueue(QueueType.Advanced);
            // var advancedQueue = AdvancedQueue.CreateQueue();

            advancedQueue.Name = "Queue 2";
            manager.Queues.Add(advancedQueue);

            manager.Enqueue(advancedQueue.Name, "Kate");
            manager.Enqueue(advancedQueue.Name, "Irma");
            manager.Enqueue(advancedQueue.Name, "Johnny");

            manager.DisplayQueue(defaultQueue.Name);
            manager.DisplayQueue(advancedQueue.Name);

            Console.ReadKey();
        }
    }
}
