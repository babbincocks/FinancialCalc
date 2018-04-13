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

                if (!double.TryParse(initial, out double a) || !double.TryParse(interestRate, out double b) || !double.TryParse(depositAmount, out double c) || !double.TryParse(lengthInYears, out double d))
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
                 The following if-else-if set is what actually sets the value of the compounding rate. On the operative side
                 of the form, there just needs to be a set way to have the user put in these values (which this
                 program does have).
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
                {   //If none of the values are met, an exception is thrown, telling the user to only use one of 
                    //those four compounding rates.

                    throw new Exception("Please only use the recommended compounding rates (Annually, Semi-Annually, Quarterly, and Monthly)");

                }

                /*
                 These two variables were created solely to make the following calculations appear a
                 bit cleaner, as their values show up multiple times throughout.
                 */
                double idc = interest / compound;
                double cty = compound * years;

                if (compound == 1)
                {
                    /*
                     This is the first calculation done, to find how much extra value is added
                     to the bank account's total due to a monthly deposit. They all follow the same
                     formula (the source of which can be found in the "Resources" form that I created
                     that is linked to the Compound Interest Calculator. The reason for the if-else-if
                     set is that the compounding rate makes a difference to how much is calculated.
                     To sum up the difference, the initial deposit needs to be multiplied by how many
                     months there are in each compounding period: Annual is multiplied by 12, Semi-Annual
                     is multiplied by 6, etc.
                     */
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

                /*
                 Then the actual total is calculated by using the formula that is also linked in the
                 Resources form, and the total without any deposits, and the deposit total are added
                 together to get the true total.
                 */
                total = principal * Math.Pow((1 + idc), cty);
                total = total + depositTotal;

                //Then, of course, the total is returned in a currency format.
                return total.ToString("c");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public static Tuple<string, string, string, string> Mortgage(string originalAmount, string downPayment, string amountLoaned, string lengthOfLoan, string interestRate, string startDate)
        {   //This is the code for the function that calculates Mortgage.
            try
            {
                //Just as a precaution, to start off, if the starting date is left null, it defaults to the current date.
                if (startDate == "")
                {
                    startDate = DateTime.Today.ToString();
                }

                //This is a bit more preliminary error handling. This checks to see that all fields are comprised of only numeric values. If any
                //field has something other than a number in it (i.e. someone puts "July 31st, 2015" in the start date), it will throw an exception.
                if (!double.TryParse(originalAmount, out double a) || !double.TryParse(downPayment, out double b) || !double.TryParse(amountLoaned, out double c) || !double.TryParse(lengthOfLoan, out double d) || !double.TryParse(interestRate, out double e) || !DateTime.TryParse(startDate, out DateTime f))
                {
                    throw new Exception("Only numbers are allowed in any of the text fields. Be sure that all of your information is comprised of ONLY numbers.");
                }

                //Now all of the result variables (the variables that will be used in the output tuple)
                //are declared, along with their default values.
                double absTotal = 0;
                double monthly = 0;
                double intTotal = 0;
                DateTime payoff = new DateTime(1900, 1, 1);

                //Then there are all of the variables that gain their values from the user inputs.
                DateTime loanStart = DateTime.Parse(startDate);
                double initial = double.Parse(originalAmount);
                double down = double.Parse(downPayment);
                double loan = double.Parse(amountLoaned);
                int loanLength = int.Parse(lengthOfLoan);
                double rate = double.Parse(interestRate);

                //This is a quick check to make sure that the amount for the initial value and the down
                //payment subtract to equal how much is being loaned; that way there aren't stray dollars
                //being thrown around.
                if (initial - down != loan)
                {
                    throw new Exception("You have unaccounted money in the loan. The loan should not differentiate from the initial amount minus the down payment.");
                }

                //This turns the annual rate that the user input (which should be, for example, "5")
                //into a percentage, and then a monthly rate, which would be dividing it by 100,
                //and then by 12, but just doing 1200 does the exact same thing.
                    rate = rate / 1200;

                /* 
                These next three lines are all of the calculations needed to get the monthly
                payment amount. It's a bit split up to make things easier on the eyes and ensure
                the order of operations are in the proper order. As the calculation of (rate + 1)
                to the power of the length of the loan shows up twice in the formula, that is turned
                into a variable.
                */
                double inRate = rate + 1;
                inRate = Math.Pow(inRate, loanLength);
                monthly = (loan * ((rate * inRate)) / (inRate - 1));

                /*
                This is the calculation for the entire total that the user would have to worry
                about. Quite simply, it takes the monthly payment, and multiplies it by how many
                times that payment would have to be made.
                */
                absTotal = monthly * loanLength;

                /*
                 This retrieves how much interest would accrue from the loan, taking the amount
                 that the user would pay, and subtracting how much they were loaned.
                 */
                intTotal = absTotal - loan;

                /*
                 The date that the loan would be paid off is calculated by adding the length of the
                 loan to when the loan starts, which is both unsurprising and very, very simple.
                 */
                payoff = loanStart.AddMonths(loanLength);

                /*
                 Finally, these previous 4 variables we've gotten the values of are put into a new
                 tuple, where they are all converted into string format, and that tuple is returned
                 from the function.
                 */
                var output = Tuple.Create<string, string, string, string>(monthly.ToString("c"), payoff.ToString("yyyy/MM/dd"), intTotal.ToString("c"), absTotal.ToString("c"));
                return output;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
