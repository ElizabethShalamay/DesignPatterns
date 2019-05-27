using System;

namespace DesignPatternsTasks.FactoryMethod
{
    public class DefaultQueue : Queue
    {
        public override QueueType QueueType => QueueType.Default;

        public static Queue CreateQueue()
        {
            return new DefaultQueue();
        }

        public override void Enqueue(string userName)
        {
            base.Enqueue(userName);
            Console.WriteLine($"Add user { userName } to default queue { Name }");
        }
    }
}
