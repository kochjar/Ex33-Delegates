using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex33_Delegates
{
    public delegate double BonusProvider(double amount);
    public class Bonuses
    {
        public static double TenPercent(double amount){ return amount * 0.10;}

        public static double FlatTwoIfAmountMoreThanFive(double amount) 
        {
            if (amount > 5) return 2;
            else return 0;
        }

    }
}
