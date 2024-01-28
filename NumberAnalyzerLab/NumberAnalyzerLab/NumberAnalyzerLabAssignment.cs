
Console.WriteLine($"What is your name?");

string userName = Console.ReadLine();

bool continueLooping = true;

while (continueLooping == true)
{

    Console.WriteLine($"{userName}, please enter in a number 1 through 100.");

    string userInput = Console.ReadLine();
    int number = int.Parse(userInput);


    if (number <= 60 && number % 2 != 0)

    {
        Console.WriteLine($"{userName}, the number you picked is odd and less than 60.");
        while (true)
        {
            Console.WriteLine("Do you want to enter another number?");
            string userAnswer = Console.ReadLine().ToLower().Trim();
            switch (userAnswer.ToLower().Trim())
            {
                case "y":
                case "yes":
                    continue;

                default:
                    Console.WriteLine("Ok, goodbye.");
                    break;
            }
            break;
        }
        break;
    }
    else if ((number >= 2 && number <= 25) && number % 2 == 0)
    {
        Console.WriteLine($"{userName}, the number you picked is even and less than 25.");
        while (true)
        {
            Console.WriteLine("Do you want to enter another number?");
            string userAnswer = Console.ReadLine().ToLower().Trim();
            switch (userAnswer.ToLower().Trim())
            {
                case "y":
                case "yes":
                    continue;
                default:
                    Console.WriteLine("Ok, goodbye.");
                    break;
            }
            break;
        }
        break;
    }
    else if ((number >= 26 && number <= 60) && number % 2 == 0)
    {
        Console.WriteLine($"{userName}, the number you picked is even and between 26 and 60 inclusive.");
        while (true)
        {
            Console.WriteLine("Do you want to enter another number?");
            string userAnswer = Console.ReadLine().ToLower().Trim();
            switch (userAnswer.ToLower().Trim())
            {
                case "y":
                case "yes":
                    continue;
                default:
                    Console.WriteLine("Ok, goodbye.");
                    break;
            }
            break;
        }
        break;
    }
    else if ((number > 60 && number < 101) && number % 2 == 0)
    {
        Console.WriteLine($"{userName}, the number you picked is even and greater than 60.");
        while (true)
        {
            Console.WriteLine("Do you want to enter another number?");
            string userAnswer = Console.ReadLine().ToLower().Trim();
            switch (userInput.ToLower().Trim())
            {
                case "y":
                case "yes":
                    continue;
                default:
                    Console.WriteLine("Ok, goodbye.");
                    break;
            }
            break;
        }
        break;
    }
    else if ((number > 60 && number < 101) && number % 2 != 0)
    {
        Console.WriteLine($"{userName}, the number you picked is odd and greater than 60.");
        while (continueLooping == true)
        {
            Console.WriteLine("Do you want to enter another number?");
            string userAnswer = Console.ReadLine().ToLower().Trim();
            switch (userInput.ToLower().Trim())
            {
                case "y":
                case "yes":
                    continue;
                default:
                    Console.WriteLine("Ok, goodbye.");
                    break;
            }
            break;
        }
        break;
    }
    else
    {
        if (true)
        {
            Console.WriteLine("You did not enter in a positive integer between 1 and 100. Do you want to try again?");
            userInput = Console.ReadLine();

            switch (userInput.ToLower().Trim())
            {
                case "y":
                case "yes":
                    continue;
                default:
                    Console.WriteLine("Goodbye.");
                    break;
            }
            break;
        }


    }




    Console.ReadKey();
}