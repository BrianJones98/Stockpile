using Caliburn.Micro;
using Stockpile.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stockpile.ViewModels
{
    public class StockpileViewModel : Screen
    {
        public BindableCollection<StockpileModel> Stockpiles { get; set; }
    }
}
