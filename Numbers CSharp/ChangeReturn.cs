namespace Numbers_CSharp
{
    internal static class ChangeReturn
    {
        internal static void ChangeReturnMethod()
        {
            (decimal cost, decimal moneyGiven) = ReadCostAndChangeInput();

            CalculateChange(cost, moneyGiven);
        }

        private static (decimal cost, decimal moneyGiven) ReadCostAndChangeInput()
        {
            decimal cost = -1;
            decimal moneyGiven = -1;

            while (cost <= 0)
            {
                Console.WriteLine("Enter cost of item (xx.xx)\n");
                string? userInputCost = Console.ReadLine();
                if (decimal.TryParse(userInputCost, out cost))
                {
                    if (cost <= 0)
                    {
                        cost = -1;
                        Console.WriteLine("Cost must be more than zero.\n");
                    }
                    else if (cost != decimal.Round(cost, 2))
                    {
                        cost = -1;
                        Console.WriteLine("Input must have two decimal places.\n");
                    }
                    
                }
                else
                {
                    cost = -1;
                    Console.WriteLine("Invalid input.\n");
                }
            }

            while (moneyGiven < 0)
            {
                Console.WriteLine("Enter money given (xx.xx)\n");
                string? userInputMoneyGiven = Console.ReadLine();
                if (decimal.TryParse(userInputMoneyGiven, out moneyGiven))
                {
                    if (moneyGiven < cost)
                    {
                        moneyGiven = -1;
                        Console.WriteLine("Money given must be at least as much as cost.\n");
                    }
                    else if (moneyGiven != decimal.Round(moneyGiven, 2))
                    {
                        moneyGiven = -1;
                        Console.WriteLine("Input must have two decimal places.\n");
                    }
                }
                else
                {
                    moneyGiven = -1;
                    Console.WriteLine("Invalid input.\n");
                }
            }

            return (cost, moneyGiven);
        }

        private static void CalculateChange(decimal cost, decimal moneyGiven)
        {
            int dollars = 0, quarters = 0, dimes = 0, nickels = 0, pennies = 0;
            decimal countdown = moneyGiven - cost;
            decimal change = countdown;

            if (countdown == 0)
            {
                Console.WriteLine("You gave the exact amount. Change: $0.\n");
                return;
            }

            CalculateDollars(ref dollars, ref countdown);

            CalculateQuarters(ref quarters, ref countdown);

            CalculateDimes(ref dimes, ref countdown);

            CalculateNickels(ref nickels, ref countdown);

            CalculatePennies(ref pennies, ref countdown);

            Console.WriteLine($"Your total change is ${change}. You will receive back {dollars} dollars, {quarters} quarters, {dimes} dimes, " +
                $"{nickels} nickels, and {pennies} pennies.\n");
        }

        private static void CalculateDollars(ref int dollars, ref decimal countdown)
        {
            while (countdown >= 1)
            {
                dollars++;
                countdown--;
            }
        }

        private static void CalculateQuarters(ref int quarters, ref decimal countdown)
        {
            while (decimal.Compare(countdown, 0.25m) != -1)
            {
                quarters++;
                countdown -= 0.25m;
            }
        }

        private static void CalculateDimes(ref int dimes, ref decimal countdown)
        {
            while (decimal.Compare(countdown, 0.10m) != -1)
            {
                dimes++;
                countdown -= 0.10m;
            }
        }

        private static void CalculateNickels(ref int nickels, ref decimal countdown)
        {
            while (decimal.Compare(countdown, 0.05m) != -1)
            {
                nickels++;
                countdown -= 0.05m;
            }
        }

        private static void CalculatePennies(ref int pennies, ref decimal countdown)
        {
            while (decimal.Compare(countdown, 0.01m) != -1)
            {
                pennies++;
                countdown -= 0.01m;
            }
        }
    }


}
