using NUnit.Framework;
using FluentAssertions;
using System;
using DesignPatternsTasks.FactoryMethod;
using Autofac;

namespace DesignPatternsTests
{
    public class FactoryMethodTests
    {
        private IComponentContext _context;

        [SetUp]
        public void Setup()
        {
            _context = FactoryModule.BuildContainer();
        }

        // Simple Factory 
        [TestCase(QueueType.Default, typeof(DefaultQueue))]
        [TestCase(QueueType.Advanced, typeof(AdvancedQueue))]
        public void CreateQueue_ShouldReturnQueueOfCorrectType_FromManager(QueueType queueType, Type expectedQueueType)
        {
            var queueManager = _context.Resolve<IQueueManager>();

            var queue = queueManager.CreateQueue(queueType);

            queue.Should().BeOfType(expectedQueueType);
        }

        // Simple Factory (Single Responsibility Principle)
        [TestCase(QueueType.Default, typeof(DefaultQueue))]
        [TestCase(QueueType.Advanced, typeof(AdvancedQueue))]
        public void CreateQueue_ShouldReturnQueueOfCorrectType_FromFactory(QueueType queueType, Type expectedQueueType)
        {
            var queueFactory = _context.Resolve<IQueueFactory>();

            var queue = queueFactory.CreateQueue(queueType);

            queue.Should().BeOfType(expectedQueueType);
        }

        // Separate Factory Methods
        [Test]
        public void CreateQueue_ShouldCreateDefaultQueue()
        {
            Queue queue = DefaultQueue.CreateQueue();

            queue.Should().BeOfType(typeof(DefaultQueue));
        }

        [Test]
        public void CreateQueue_ShouldCreateAdvancedQueue()
        {
            Queue queue = AdvancedQueue.CreateQueue();

            queue.Should().BeOfType(typeof(AdvancedQueue));
        }
    }
}