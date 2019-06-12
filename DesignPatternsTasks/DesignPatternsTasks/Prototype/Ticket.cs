using System;

namespace DesignPatternsTasks.Prototype
{
    [Serializable]
    public class Ticket
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsBooked { get; set; }
    }
}
