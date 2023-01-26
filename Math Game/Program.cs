var date = DateTime.UtcNow;

string name = GetName();

Menu(name);

string GetName()
{
    Console.Write("Please enter your name: ");
    var name = Console.ReadLine();
    return name;
}

void Menu(string name)
{
    Console.WriteLine("------------------------------------------------");
    Console.WriteLine("Hello " + name + ". It's " + date + ". This is your math game. That's great that you are working on improve your math skills!");
    Console.WriteLine("\n");
    Console.WriteLine(@$"Please choose which games you want to play:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");
    Console.WriteLine("------------------------------------------------");

    var gameSelected = Console.ReadLine();

    switch (gameSelected.Trim().ToLower())
    {
        case "a":
            AdditionGame("Addition game selected");
            break;
        case "s":
            SubtractionGame("Subtraction game selected!");
            break;
        case "m":
            MultiplicationGame("Multiplication game selected!");
            break;
        case "d":
            DivisonGame("Division game selected!");
            break;
        case "q":
            Console.WriteLine("Game Over! See you Later!");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid input");
            Environment.Exit(2);
            break;
    }

}

void AdditionGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var result = Console.ReadLine();
        bool correct = false;

        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("Correct, good job!");
            score++;
        }
        else
        {
            Console.WriteLine("Wrong answer, good luck on next question.");
        }

        if (i == 4)
        {
            Console.WriteLine($"Game over! Your final score is {score}");
        }
    }
}

void SubtractionGame(string message)
{
    Console.WriteLine(message);
}

void DivisonGame(string message)
{
    Console.WriteLine(message);
}

void MultiplicationGame(string message)
{
    Console.WriteLine(message);
}

