namespace DesignPatternsTasks.Singleton
{
    //public class QueueConnectionProvider
    //{
    //    private static readonly QueueConnectionProvider instance = new QueueConnectionProvider();

    //    public static QueueConnectionProvider GetInstance()
    //    {
    //        return instance;
    //    }
    //}

    public class QueueConnectionProvider
    {
        private static QueueConnectionProvider instance;

        private static object locker = new object();

        private QueueConnectionProvider()
        {
            instance = new QueueConnectionProvider();
        }

        public static QueueConnectionProvider GetInstance()
        {
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                        instance = new QueueConnectionProvider();
                }
            }

            return instance;
        }
    }
}
