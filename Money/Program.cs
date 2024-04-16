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
            Console.WriteLine(dollar.GetGold());
            Hryvnia hryvnia = new Hryvnia(1000);
            Console.WriteLine(hryvnia.GetGold());
            Money.Exchange(hryvnia, dollar);
            Console.WriteLine(hryvnia.Value);
        }
    }
}
