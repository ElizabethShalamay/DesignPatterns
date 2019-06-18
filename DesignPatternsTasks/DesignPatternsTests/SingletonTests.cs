using DesignPatternsTasks.Singleton;
using FluentAssertions;
using NUnit.Framework;
using System.Threading;

namespace DesignPatternsTests
{
    [TestFixture]
    public class SingletonTests
    {
        [Test]
        public void ShouldReturnSameObject_ForSingleThread()
        {
            var queueConnectionProvider1 = QueueConnectionProvider.GetInstance();
            var queueConnectionProvider2 = QueueConnectionProvider.GetInstance();
            queueConnectionProvider1.Should().BeSameAs(queueConnectionProvider2);
        }

        [Test]
        public void ShouldReturnSameObject_ForSeveralThreads()
        {
            QueueConnectionProvider queueConnectionProvider1 = null;
            new Thread(() =>
            {
                queueConnectionProvider1 = QueueConnectionProvider.GetInstance();
            }).Start();
          
            var queueConnectionProvider2 = QueueConnectionProvider.GetInstance();
            queueConnectionProvider1.Should().BeSameAs(queueConnectionProvider2);
        }
    }
}
