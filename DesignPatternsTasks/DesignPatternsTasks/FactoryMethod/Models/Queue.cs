using System;
using System.Collections.Generic;

namespace DesignPatternsTasks.FactoryMethod
{
    public abstract class Queue
    {
        public Queue()
        {
            Users = new List<string>();
        }

        public abstract QueueType QueueType { get; }

        public List<string> Users { get; set; }

        public string Name { get; set; }

        public virtual void Enqueue(string userName)
        {
            Users.Add(userName);
        }
    }
}
