﻿using BalanceMonitor.Accounting.Application.Projections;
using System;
using System.Collections.ObjectModel;

namespace BalanceMonitor.ViewModels
{
  public interface IAccountDailyBalanceRegion
  {
    ObservableCollection<AccountDailyBalance> DailyBalance { get; }
    DateTime Date { get; set; }
  }
}
