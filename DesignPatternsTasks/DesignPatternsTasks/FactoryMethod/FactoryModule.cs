using Autofac;

namespace DesignPatternsTasks.FactoryMethod
{
    public class FactoryModule : Module
    {
        public static IComponentContext BuildContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<DefaultQueue>().Keyed<Queue>(QueueType.Default);
            builder.RegisterType<AdvancedQueue>().Keyed<Queue>(QueueType.Advanced);
            builder.RegisterType<QueueFactory>().As<IQueueFactory>();
            builder.RegisterType<QueueManager>().As<IQueueManager>();

            return builder.Build();
        }
    }
}
