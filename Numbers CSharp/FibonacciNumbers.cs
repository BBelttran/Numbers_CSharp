namespace Numbers_CSharp
{
    internal static class FibonacciNumbers
    {
        internal static void FindFibonacciSequenceToTheNthDigit()
        {
            int nthNumber = ReadFibonacciDigitInput();

            FibonacciSequence(nthNumber);
        }

        private static int ReadFibonacciDigitInput()
        {
            int userInput = 0;

            while (userInput < 1 || userInput > 30)
            {
                Console.WriteLine("Type how many iterations of the fibonacci sequence to go through (1-30)");
                int.TryParse(Console.ReadLine(), out userInput);
            }

            return userInput;
        }

        private static void FibonacciSequence(int nthNumber)
        {
            int firstNumber = 0; 
            int secondNumber = 1;
            string fibonacciNumbersString = $"{firstNumber}, {secondNumber}";

            if (nthNumber == 0)
                Console.WriteLine(firstNumber);

            else if (nthNumber == 1)
                Console.WriteLine($"{firstNumber}, {secondNumber}");

            else 
            {
                for (int i = 3; i <= nthNumber; i++)
                {
                    int currentDigit = firstNumber + secondNumber;
                    fibonacciNumbersString += $", {currentDigit}";

                    firstNumber = secondNumber;
                    secondNumber = currentDigit;
                }
            }

            Console.WriteLine(fibonacciNumbersString);
        }
    }
}
