﻿using System;

namespace MicroRabbit.Domain.Events
{
    public abstract class Event
    {
        public DateTime Timestamp { get; protected set; }

        public Event() => Timestamp = DateTime.Now;
    }
}
