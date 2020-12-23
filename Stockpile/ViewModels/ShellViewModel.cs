using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;

namespace Stockpile.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        public void LoadStockpilePage()
        {
            ActivateItem(new StockpileViewModel());
        }

        public void LoadItemPage()
        {
            ActivateItem(new ItemViewModel());
        }
    }
}
