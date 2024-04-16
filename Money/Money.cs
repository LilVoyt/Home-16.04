using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    internal abstract class Money
    {
        public double Value { get; set; }
        public double IndexGold { get; set; }
        public Money(double value)
        {
            Value = value;
            IndexGold = 0;
        }
        public Money(double value, double indexGold)
        {
            Value = value;
            IndexGold = indexGold;
        }
        public double GetGold()
        {
            double res;
            res = Value / IndexGold;
            return res;
        }
        public static void Exchange(Money Reciever, Money Sender)
        {
            Console.WriteLine(Reciever.Value + " += " + Sender.GetGold() + " * " + Reciever.IndexGold);
            Reciever.Value += Sender.GetGold() * Reciever.IndexGold;
            Sender.Value = 0;
        }
    }
}
