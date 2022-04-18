while (true)
{
    bool validInput = false;
    string? userInput = null;

    while (!validInput)
    {
        Console.WriteLine("Choose one of the following with the corresponding number: \n (1) Find Pi to the nth digit \n (2) Find Fibonacci sequence to the nth digit \n");
        userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
                Numbers_CSharp.Pi.FindPIToTheNthDigit(); //Enter a number and have the program generate PI
                                                         //up to that many decimal places. Limit = 14.
                validInput = true;
                break;

            case "2":
                Numbers_CSharp.FibonacciNumbers.FindFibonacciSequenceToTheNthDigit(); // Enter a number and have the program generate
                                                                                      // the Fibonacci sequence to that number or to the Nth number.
                validInput = true;
                break;
        }
    }
    validInput = false;

    while (!validInput)
    {
        Console.WriteLine("Would you like to continue? (y/n)");
        userInput = Console.ReadLine();

        if (!string.IsNullOrEmpty(userInput))
            userInput = userInput.ToLower();

        if (userInput == "y" || userInput == "n")
            validInput = true;
    }

    if (userInput == "n")
        return;

}