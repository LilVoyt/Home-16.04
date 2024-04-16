using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal class User
    {
        public string Name { get; set; }
        public Money money { get; set; }
        public List<string> Items { get; set; }
        public User(string name, Money money)
        {
            Name = name;    
            this.money = money;
            Items = new List<string>();
        }
        public void BuyItem(Business business)
        {
            Money.Transaction(business.account, this.money, business.ValuePerItem);
            business.ItemsNumber -= 1;
        }
        public void BuyItem(Business business, int number)
        {
            Money.Transaction(business.account, this.money, business.ValuePerItem);
            business.ItemsNumber -= number;
        }
    }
}
