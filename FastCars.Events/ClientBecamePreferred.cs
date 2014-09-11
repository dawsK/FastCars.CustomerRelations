using System;
using NServiceBus;

namespace FastCars.Events
{
    public class ClientBecamePreferred : IEvent
    {
        public Guid ClientId { get; set; }
        public DateTime PreferredUntil { get; set; }
    }
}
