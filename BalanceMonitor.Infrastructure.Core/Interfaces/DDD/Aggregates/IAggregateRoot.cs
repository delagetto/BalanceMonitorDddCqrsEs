﻿using System;
namespace BalanceMonitor.Infrastructure.Core.Interfaces.DDD
{
  public interface IAggregateRoot
  {
    Guid Id { get; }
  }
}
