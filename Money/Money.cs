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
        public double GetGold(Money amount) 
        {
            double res;
            if(amount.Value > 0 && amount.Value <= Value)
            {
                res = amount.Value / IndexGold;
                return res;
            }
            else if(amount.Value < 0)
            {
                throw new Exception("Amount of money cannot be < 0!");
            }
            else if (amount.Value >= Value) { }
            {
                throw new Exception("No such money on balance!");
            }
        }
        public static void Transaction(Money Reciever, Money Sender, Money amount)
        {
            Console.WriteLine(Reciever.Value + " += " + Sender.GetGold(amount) + " * " + Reciever.IndexGold);
            Reciever.Value += amount.GetGold(amount) * Reciever.IndexGold;
            Sender.Value -= amount.GetGold(amount) * Sender.IndexGold;
        }
        public static void TransactionForCompany(Money Reciever, Money Sender, Money amount)
        {
            Console.WriteLine(Reciever.Value + " += " + Sender.GetGold(amount) + " * " + Reciever.IndexGold);
            Reciever.Value += amount.GetGold(amount) * Reciever.IndexGold;
            Sender.Value -= Sender.GetGold(amount) * Sender.IndexGold;
        }
    }
}
