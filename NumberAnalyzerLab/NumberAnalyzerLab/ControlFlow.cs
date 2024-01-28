

//using System.ComponentModel.Design;

////bool isEligible = true;
//if (isEligible)
//{
//    Console.WriteLine("You are eligible");
//}

//int age = 16;

//if (age >= 13)
//{
//    Console.WriteLine("You are an child");
//}
//else if (age < 18)
//{
//    Console.WriteLine("You are an teenager.");
//}
//else
//{
//    Console.WriteLine("You are an adult.");
//}

//Console.WriteLine("What is the game score?");

//string userInput = Console.ReadLine();
//int gameScore = int.Parse(userInput);

////int gameScore = int.Parse(Console.ReadLine());

//if (gameScore >= 90)
//{
//    Console.WriteLine("Great Job!");
//}
//else if (gameScore >= 70)
//{
//    Console.WriteLine("Good Job");
//}
//else
//{
//    Console.WriteLine("You can do better");
//}

//int dayNumber = 3;

//switch (dayNumber)
//{
//    case 1:
//        Console.WriteLine("Monday");
//        break;
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    case 3:
//        Console.WriteLine("Wednesday");
//        break;
//    default:
//        Console.WriteLine("That is not a day");
//        break;
//}

//Console.WriteLine("Select and option:\n 1. Play \n 2. Settings \n 3. Exit");
//userInput = Console.ReadLine();
//int option = int.Parse(userInput);

//switch (option)
//{
//    case 1:
//        Console.WriteLine("Starting game...");
//        break;
//    case 2:
//        Console.WriteLine("Opening settings...");
//        break;
//    case 3:
//        Console.WriteLine("Exiting...");
//        break;
//    default:
//        Console.WriteLine("Invalid Option");
//        break;
//}

//Console.WriteLine("How are you feeling?");
//userInput = Console.ReadLine();

//switch (userInput.ToLower().Trim())
//{
//    case "bad":
//    case "sad":
//    case "unhappy":
//        Console.WriteLine("I'm sorry you aren't feeling great");
//        break;
//    case "good":
//    case "great":
//    case "happy":
//        Console.WriteLine("Opening settings...");
//        break;
//    default:
//        Console.WriteLine("I don't know that feeling");
//        break;
//}

//// SYNTAX: condition ? valueIfTrue : valueIfFalse

//string mirrorEmotion = userInput.ToLower() == "bad" ? "Anger" : "Joy";

//if (userInput.ToLower() == "bad")
//{
//    mirrorEmotion = "Anger";
//}
//else
//{
//    mirrorEmotion = "Joy";
//}

//{
//    Console.ReadKey();
//}
