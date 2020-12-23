using System;
using System.Collections.Generic;
using System.Text;

namespace Stockpile.Models
{
    public class StockpileModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ItemModel> Items { get; }
        /*
         * Create different class for shopping lists later that uses this attribute
        public decimal Total
        {
            get
            {
                decimal sum = 0;
                foreach(Item item in Items)
                {
                    sum += item.Price;
                }

                return sum;
            }
        }
        */
        public void AddItem(ItemModel item)
        {
            this.Items.Add(item);
        }
    }
}
