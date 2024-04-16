using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal class Business
    {
        public string Name { get; set; }
        public Money account { get; set; }
        public int ItemsNumber { get; set; }
        public Money ValuePerItem { get; set; }
        public Business(string name, Money account, int itemsNumber, Money valuePerItem)
        {
            Name = name;
            this.account = account;
            ItemsNumber = itemsNumber;
            ValuePerItem = valuePerItem;
        }
    }
}
