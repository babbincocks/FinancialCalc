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
        {       //This is the code for the CompoundInterest function.
            try
            {
                //It starts off with checking to see if any variables are empty, and raises
                //an exception, as it needs all values.

                if (initial == "" || interestRate == "" || depositAmount == "" || lengthInYears == "" || compoundRate == "")
                {
                    throw new Exception("Please fill in all white fields with information, so as to do a proper calculation.");
                }


                //After that, it checks to see if all of the explicitly entered information is purely
                //numeric. The only field that doesn't need to be checked for this is the compound rate 
                //(that is taken care of elsewhere).

                if (!double.TryParse(initial, out double a)|| !double.TryParse(interestRate, out double b) || !double.TryParse(depositAmount, out double c) || !double.TryParse(lengthInYears, out double d))
                {
                    throw new Exception("All fields you enter information into, except for Yearly Compound Rate, should be only numbers.");
                }

                /*
                Then every variable that will be used is declared. Most of them are immediately given values by
                parsing the values the user entered into doubles, while the compound variable will be taken
                care of in a couple steps, as it's a bit different from the others.
                */
                double total = 0;
                double principal = double.Parse(initial);
                double interest = double.Parse(interestRate) / 100;
                double deposit = double.Parse(depositAmount);
                double years = double.Parse(lengthInYears);
                double compound = 0;
                double depositTotal = 0;

                /*
                 This is a check to make sure that the user's value for the amount of years is a positive number.
                 They could theoretically insert months, or even days as well, so it just makes sure that the value
                 inserted is any positive number.
                 */
                if (years <= 0)
                {
                    throw new Exception("You must put in some amount greater than 0 for the number of years.");
                }

                /*
                 The following if-else-if set is what actually sets the value of the compounding rate. On the side
                 of the interface, there just needs to be a set way to 
                */
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
                else
                {
                    throw new Exception("Please only use the recommended compounding rates.");
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
