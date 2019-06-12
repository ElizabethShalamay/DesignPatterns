using DesignPatternsTasks.Builder.Models;
using DesignPatternsTasks.FactoryMethod;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DesignPatternsTasks.Prototype
{
    [Serializable]
    public class Queue : ITemplate
    {
        public Queue()
        {
            Tickets = new List<Ticket>();
        }

        public string Name { get; set; }

        public QueueType QueueType { get; }

        public bool IsActive { get; set; }

        public Organization Organization { get; set; }

        public string Address { get; set; }

        public List<Ticket> Tickets { get; set; }


        public ITemplate AsTemplate()
        {
            var queueCopy = new Queue();

            using (var stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, this);
                stream.Seek(0, SeekOrigin.Begin);
                queueCopy = (Queue)formatter.Deserialize(stream);
            }
            queueCopy.IsActive = false;
            queueCopy.Tickets.ForEach(ticket => ticket.IsBooked = false);

            return queueCopy;
        }
    }
}
