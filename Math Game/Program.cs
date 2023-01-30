using System;

var date = DateTime.UtcNow;

var games = new List<string>();

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

    bool isGameOn = true;

    do
    {
        Console.Clear();
        Console.WriteLine(@$"Please choose which games you want to play:
V - View Previous Games
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
                AdditionGame("Addition game");
                break;
            case "s":
                SubtractionGame("Subtraction game");
                break;
            case "m":
                MultiplicationGame("Multiplication game");
                break;
            case "d":
                DivisonGame("Division game");
                break;
            case "q":
                Console.WriteLine("Game Over! See you");
                isGameOn = false;
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid input");
                Environment.Exit(2);
                break;
        }
    } while (isGameOn);

}

void AdditionGame(string message)
{
    Console.Clear();
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

        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("Correct, good job! Type any key for next question.");
            Console.ReadLine();
            score++;
        }
        else
        {
            Console.WriteLine("Wrong answer, good luck on next question, Type any key for next question.");
            Console.ReadLine();
        }
    }
    Console.WriteLine($"Game over! Your final score is {score}. Press ant key to go back to Main Menu.");
    Console.ReadLine();

    games.Add($"{DateTime.Now} - Addition: Score={score}");
}

void SubtractionGame(string message)
{
    var random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} - {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber - secondNumber)
        {
            Console.WriteLine("Correct, good job! Type any key for next question.");
            Console.ReadLine();
            score++;
        }
        else
        {
            Console.WriteLine("Wrong answer, good luck on next question, Type any key for next question.");
            Console.ReadLine();
        }
    }
    Console.WriteLine($"Game over! Your final score is {score}. Press ant key to go back to Main Menu.");
    Console.ReadLine();
}

void DivisonGame(string message)
{
    var score = 0;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        var divisionNumbers = GetDivisionNumber();
        var firstNumber = divisionNumbers[0];
        var secondNumber = divisionNumbers[1];

        Console.WriteLine($"{firstNumber} / {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber / secondNumber)
        {
            Console.WriteLine("Correct, good job! Type any key for next question.");
            Console.ReadLine();
            score++;
        }
        else
        {
            Console.WriteLine("Wrong answer, good luck on next question, Type any key for next question.");
            Console.ReadLine();
        }
    }
    Console.WriteLine($"Game over! Your final score is {score}. Press ant key to go back to Main Menu.");
    Console.ReadLine();
}

void MultiplicationGame(string message)
{
    var random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);

        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} * {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber * secondNumber)
        {
            Console.WriteLine("Correct, good job! Type any key for next question.");
            Console.ReadLine();
            score++;
        }
        else
        {
            Console.WriteLine("Wrong answer, good luck on next question, Type any key for next question.");
            Console.ReadLine();
        }
    }
    Console.WriteLine($"Game over! Your final score is {score}. Press ant key to go back to Main Menu.");
    Console.ReadLine();
}

int[] GetDivisionNumber()
{
    var random = new Random();
    int firstNumber = random.Next(1, 99);
    int secondNumber = random.Next(1, 99);

    var result = new int[2];

    while (firstNumber % secondNumber != 0)
    {
        firstNumber = random.Next(1, 99);
        secondNumber = random.Next(1, 99);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;

    return result;
}