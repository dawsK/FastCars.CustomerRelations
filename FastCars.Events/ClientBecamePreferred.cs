﻿using System;

namespace FastCars.Events
{
    public class ClientBecamePreferred
    {
        public Guid ClientId { get; set; }
        public DateTime PreferredUntil { get; set; }
    }
}
