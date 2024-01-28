
//string userInput = "";

//for (int i = 0; i < 10; i++)
//{
//    if (i == 5)
//    {
//        break;
//    }
//    Console.WriteLine(i);
//}




//Console.WriteLine("Done");
//Console.ReadKey();


//while (true)
//{
//    Console.WriteLine("What is your name?");
//    string userName = Console.ReadLine().ToLower().Trim();
//    if (userName == "kyle")
//    {
//        break;
//    }
//}

//Console.WriteLine("Give me a number: ");
//int userNumber = int.Parse(Console.ReadLine());

//for (int i = 0; i <= userNumber; i++)
//{
//    if (i % 2 == 0)
//    {
//        continue;
//    }

//    Console.WriteLine(i);
//}



//bool continueLooping = true;
//while (continueLooping == true)
//{
//    Console.Write("Do you want to play again (yes/no)?");
//    userInput = Console.ReadLine();

//    switch (userInput.ToLower().Trim())
//    {
//        case "y":
//        case "yes":
//            Console.WriteLine("Great, I love playing games with you");
//            break;
//        default:
//            Console.WriteLine("You didnt say, so I'll see you later");
//            continueLooping = false;
//            break;
//    }
//}

//bool playAgain;

//do
//{
//    Console.WriteLine("This is the spot we are playing are game. Isn't it fun");
//    Console.WriteLine("Now our game is done");
//    Console.WriteLine("Do you want to play again (y/n)");
//    playAgain = Console.ReadLine().ToLower().Trim() == "y" ? true : false;
//} while (playAgain == true);

//bool isDataValid = true;
//int hoursWorked = 0;
//double hourlyWage = 0;
//do
//{
//    hoursWorked = 4000;

//    Console.WriteLine("What is your hourly wage?");
//    userInput = Console.ReadLine();
//    try
//    {
//        hourlyWage = double.Parse(userInput);
//    }
//    catch (FormatException)
//    {
//        isDataValid = false;
//    }
//    if (isDataValid == true)
//    {
//        if (hourlyWage < 1)
//        {
//            bool isGreaterThanZero = false;
//            isDataValid = false;
//        }
//        /*if (isGreaterThanZero) ;*/ //means your varible is not within brackets
//    }
//} while (isDataValid == false);

//double paycheck = hoursWorked * hourlyWage;



//Get hour worked








//while (userInput.ToLower().Trim() != "exit")
//{
//    Console.Write("Enter a command (type 'exit' to stop): ");
//userInput = Console.ReadLine();
//Console.WriteLine(userInput);
//}
//Console.WriteLine("Goodbye");

//Console.ReadKey();

