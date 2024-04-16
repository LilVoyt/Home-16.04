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
            //Dollar dollar = new Dollar(100);
            //Console.WriteLine(dollar.GetGold(100));
            //Hryvnia hryvnia = new Hryvnia(1000);
            //Console.WriteLine(hryvnia.GetGold(1000));
            //Console.WriteLine(dollar.GetGold() + " = " + dollar.GetGold(100));
            //Money.Transaction(hryvnia, dollar, 10);
            //Console.WriteLine(hryvnia.Value);
            //Business business = new Business("Business1", hryvnia, 13, 23.3465);

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
