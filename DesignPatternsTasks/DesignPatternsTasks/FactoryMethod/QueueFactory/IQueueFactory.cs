namespace DesignPatternsTasks.FactoryMethod
{
    public interface IQueueFactory
    {
        Queue CreateQueue(QueueType queueType);
    }
}
