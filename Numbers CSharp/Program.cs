bool isProgramRunning = true;
while (isProgramRunning)
{
    bool isValidInput = false;
    string? userInput = null;

    while (!isValidInput)
    {
        Console.WriteLine("Choose one of the following with the corresponding number: \n (1) Find Pi to the nth digit \n (2) Find Fibonacci sequence to the nth digit \n " +
            "(3) Calculate change from given cost \n");
        userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
                Numbers_CSharp.Pi.FindPIToTheNthDigit(); //Enter a number and have the program generate PI
                                                         //up to that many decimal places. Limit = 14.
                isValidInput = true;
                break;

            case "2":
                Numbers_CSharp.FibonacciNumbers.FindFibonacciSequenceToTheNthDigit(); // Enter a number and have the program generate
                                                                                      // the Fibonacci sequence to that number or to the Nth number.
                isValidInput = true;
                break;

            case "3":
                Numbers_CSharp.ChangeReturn.ChangeReturnMethod();       //The user enters a cost and then the amount of money given.
                                                                        //The program will figure out the change and the number of quarters, dimes, nickels,
                                                                        //pennies needed for the change.

                isValidInput = true;
                break;

            default:
                Console.WriteLine("Invalid input. Try again.\n");
                break;
        }
    }
    isValidInput = false;

    while (!isValidInput)
    {
        Console.WriteLine("Would you like to continue? (y/n)");
        userInput = Console.ReadLine();

        if (!string.IsNullOrEmpty(userInput))
            userInput = userInput.ToLower();

        if (userInput == "y" || userInput == "n")
            isValidInput = true;
    }

    if (userInput == "n")
        isProgramRunning = false;

}