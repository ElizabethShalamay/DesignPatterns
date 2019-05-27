using System;

namespace DesignPatternsTasks.FactoryMethod
{
    public class AdvancedQueue : Queue
    {
        public override QueueType QueueType => QueueType.Advanced;

        public static Queue CreateQueue()
        {
            return new AdvancedQueue();
        }

        public override void Enqueue(string userName)
        {
            base.Enqueue(userName);
            Console.WriteLine($"Add user { userName } to queue { Name }");
        }
    }
}
