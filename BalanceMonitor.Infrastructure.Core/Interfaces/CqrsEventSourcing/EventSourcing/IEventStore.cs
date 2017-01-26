﻿using BalanceMonitor.Infrastructure.Core.Interfaces.DDD;
using System.Collections.Generic;

namespace BalanceMonitor.Infrastructure.Core.Interfaces.EventSourcing
{
  public interface IEventStore
  {
    IEnumerable<IEvent> Events { get; }

    void Store<TEvent>(IEnumerable<TEvent> events) where TEvent : IEvent;
  }
}
