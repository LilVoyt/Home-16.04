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
            Dollar dollar = new Dollar(100);
            Console.WriteLine(dollar.GetGold(100));
            Hryvnia hryvnia = new Hryvnia(1000);
            Console.WriteLine(hryvnia.GetGold(1000));
            Console.WriteLine(dollar.GetGold() + " = " + dollar.GetGold(100));
            Money.Exchange(hryvnia, dollar, 10);
            Console.WriteLine(hryvnia.Value);
            Business business = new Business("Business1", hryvnia, 13, 23.3465);
        }
    }
}
