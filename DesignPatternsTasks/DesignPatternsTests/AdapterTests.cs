using DesignPatternsTasks.Adapter;
using DesignPatternsTasks.Prototype;
using NSubstitute;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternsTests
{
    [TestFixture]
    public class AdapterTests
    {
        private IQueueService _queueService;
        private IAsyncQueueService _asyncQueueService;

        [SetUp]
        public void SetUp()
        {
            _queueService = Substitute.For<IQueueService>();
            _asyncQueueService = new AsyncQueueService(_queueService);
        }

        [Test]
        public async Task GetQueueByNameAsync_ShouldCallAdapteeMethod()
        {
            _queueService.GetQueueByName(Arg.Any<string>()).Returns(new Queue());

            var result = await _asyncQueueService.GetQueueByNameAsync(string.Empty);

            _queueService.Received().GetQueueByName(string.Empty);
        }

        [Test]
        public async Task GetQueueByOrganizationAsync_ShouldCallAdapteeMethod()
        {
            _queueService.GetQueuesByOrganization(Arg.Any<string>()).Returns(new List<Queue>());

            var result = await _asyncQueueService.GetQueuesByOrganizationAsync(string.Empty);

            _queueService.Received().GetQueuesByOrganization(string.Empty);
        }

        [Test]
        public async Task CreateQueueAsync_ShouldCallAdapteeMethod()
        {
            _queueService.When(service => service.CreateQueue(Arg.Any<Queue>()))
                .Do(x => { });

            await _asyncQueueService.CreateQueueAsync(new Queue());

            _queueService.Received().CreateQueue(Arg.Any<Queue>());
        }
    }
}
