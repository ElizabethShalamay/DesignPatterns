using DesignPatternsTasks.Builder.Builder;
using DesignPatternsTasks.Builder.Models;
using DesignPatternsTasks.Prototype;
using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace DesignPatternsTests
{
    public class PrototypeTests
    {
        [Test]
        public void AsTemplate_ShouldCreateNewQueueFromTemplate()
        {
            Queue queue = GetTestQueue();

            var newQueue = (Queue) queue.AsTemplate();

            newQueue.Name.Should().Be(queue.Name);
            newQueue.IsActive.Should().Be(false);
            newQueue.Address.Should().Be(queue.Address);
            newQueue.Organization.Name.Should().Be(queue.Organization.Name);
            newQueue.Organization.Address.Should().Be(queue.Organization.Address);
            queue.Organization.Departments.Should().BeEquivalentTo(queue.Organization.Departments);
            newQueue.Tickets.Should().HaveCount(queue.Tickets.Count);
            newQueue.Tickets[0].StartTime.Should().Be(queue.Tickets[0].StartTime);
            newQueue.Tickets[0].EndTime.Should().Be(queue.Tickets[0].EndTime);
            newQueue.Tickets[0].IsBooked.Should().Be(false);
            newQueue.Tickets[1].StartTime.Should().Be(queue.Tickets[1].StartTime);
            newQueue.Tickets[1].EndTime.Should().Be(queue.Tickets[1].EndTime);
            newQueue.Tickets[1].IsBooked.Should().Be(false);
        }

        private Queue GetTestQueue()
        {
            var organization = new OrganizationBuilder()
                .WithName("Epam")
                .WithAddress("Zhylianska, 75, 7 floor, NY")
                .WithDepartment(new Department
                {
                    Name = ".Net Unit",
                    NumberOfEmployees = 10,
                    PhoneNumber = "111-1111-1111"
                })
                .Build();
            var queue = new Queue
            {
                Name = "Queue 1",
                IsActive = true,
                Organization = organization,
                Address = organization.Address,
                Tickets = new List<Ticket>()
            };
            queue.Tickets.Add(new Ticket
            {
                StartTime = new DateTime(2019, 06, 12, 9, 30, 0),
                EndTime = new DateTime(2019, 06, 12, 10, 30, 0),
                IsBooked = true
            });
            queue.Tickets.Add(new Ticket
            {
                StartTime = new DateTime(2019, 06, 12, 10, 30, 0),
                EndTime = new DateTime(2019, 06, 12, 11, 30, 0),
                IsBooked = false
            });

            return queue;
        }
    }
}
