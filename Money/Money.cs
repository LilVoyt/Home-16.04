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
        public double GetGold(double amount)
        {
            double res;
            if(amount > 0 && amount <= Value)
            {
                res = amount / IndexGold;
                return res;
            }
            else if(amount < 0)
            {
                throw new Exception("Amount of money cannot be < 0!");
            }
            else if (amount >= Value) { }
            {
                throw new Exception("No such money on balance!");
            }
        }
        public static void Exchange(Money Reciever, Money Sender, double amount)
        {
            Console.WriteLine(Reciever.Value + " += " + Sender.GetGold(amount) + " * " + Reciever.IndexGold);
            Reciever.Value += Sender.GetGold(amount) * Reciever.IndexGold;
            Sender.Value -= amount;
        }
    }
}
