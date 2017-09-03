﻿using EventBus.Core;

namespace EventBus.Sample.Events
{
    [Event(Name = "NewUser")]
    public class NewUserEvent
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }
    }
}
