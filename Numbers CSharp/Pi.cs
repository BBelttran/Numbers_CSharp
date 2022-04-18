namespace Numbers_CSharp
{
    internal static class Pi
    {
        internal static void FindPIToTheNthDigit()
        {
            string piString = Math.PI.ToString();

            int numberOfDigits = ReadPiDigitInput();

            string piSubstring = PiToSetDigits(piString, numberOfDigits);

            Console.WriteLine(piSubstring);
        }

        private static int ReadPiDigitInput()
        {
            int userInput = 0;

            while (userInput < 1 || userInput > 14)
            {
                Console.WriteLine("Type how many digits of pi to display (1-14)");
                int.TryParse(Console.ReadLine(), out userInput);
            }

            return userInput;
        }

        private static string PiToSetDigits(string piString, int numberOfDigits)
        {
            return $"3.{piString.Substring(2, numberOfDigits)}";    /* starts at 2 as that's where 
                                                                    the decimals start */
        }

    }
}
