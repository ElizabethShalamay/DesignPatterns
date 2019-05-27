using Autofac;

namespace DesignPatternsTasks.FactoryMethod
{
    public class QueueFactory : IQueueFactory
    {
        private IComponentContext _context;

        public QueueFactory(IComponentContext context)
        {
            _context = context;
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
    }
}
