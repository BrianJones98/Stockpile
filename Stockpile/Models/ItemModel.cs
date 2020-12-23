using System;
using System.Collections.Generic;
using System.Text;

namespace Stockpile.Models
{
    public class ItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}
