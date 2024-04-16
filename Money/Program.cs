using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Business Shop = new Business("ATB", new Dollar(100), 5, new Dollar(10));
            User user1 = new User("User1", new Hryvnia(1000));
            Console.WriteLine($"Money of Shop: {Shop.account.Value}, Item number: {Shop.ItemsNumber}");
            Console.WriteLine($"Money of User: {user1.money.Value}");
            user1.BuyItem(Shop);
            Console.WriteLine($"Money of Shop: {Shop.account.Value}, Item number: {Shop.ItemsNumber}");
            Console.WriteLine($"Money of User: {user1.money.Value}");
        }
    }
}
