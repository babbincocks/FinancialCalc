using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MortgageCalculator
{
    class Financial
    {
        public static string CompoundInterest(string initial, string interestRate, string depositAmount, string lengthInYears, string compoundRate)
        {
            try
            {
                if (initial == "" || interestRate == "" || depositAmount == "" || lengthInYears == "" || compoundRate == "")
                {
                    throw new Exception("Please fill in all fields with information, so as to do a proper calculation.");
                }
                if (compoundRate != "Annually"|| compoundRate != "Semi-Annually" || compoundRate != "Quarterly" || compoundRate != "Monthly")
                { }
                double total = 0;
                double principal = double.Parse(initial);
                double interest = double.Parse(interestRate) / 100;
                double deposit = double.Parse(depositAmount);
                double years = double.Parse(lengthInYears);
                double compound = 0;
                double depositTotal = 0;

                if (years <= 0)
                {
                    throw new Exception("You must put in some amount greater than 0 for the number of years.");
                }

                if (compoundRate == "Annually")
                {
                    compound = 1;

                }
                else if (compoundRate == "Semi-Annually")
                {
                    compound = 2;

                }
                else if (compoundRate == "Quarterly")
                {
                    compound = 4;

                }
                else if (compoundRate == "Monthly")
                {
                    compound = 12;

                }
                double idc = interest / compound;
                double cty = compound * years;

                if (compound == 1)
                {
                    depositTotal = (deposit * 12) * ((Math.Pow((1 + idc), cty) - 1) / idc);
                }
                else if (compound == 2)
                {
                    depositTotal = (deposit * 6) * ((Math.Pow((1 + idc), cty) - 1) / idc);
                }
                else if (compound == 4)
                {
                    depositTotal = (deposit * 3) * ((Math.Pow((1 + idc), cty) - 1) / idc);
                }
                else if (compound == 12)
                {
                    depositTotal = deposit * ((Math.Pow((1 + idc), cty) - 1) / idc);
                }

                total = principal * Math.Pow((1 + idc), cty);
                total = total + depositTotal;

                return total.ToString("c");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string Mortgage(string originalAmount, string downPayment, string amountLoaned, string loanLength, string interestRate)
        {
            double total = 0;



            return total.ToString("c");
        }
    }
}
