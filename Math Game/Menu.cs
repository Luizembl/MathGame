namespace Math_Game
{
	internal class Menu
	{
        GameLogic gameLogic = new();

        internal void ShowMenu(string name, DateTime date)
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
                    case "v":
                        Helpers.GetGames();
                        break;
                    case "a":
                        gameLogic.AdditionGame("Addition game");
                        break;
                    case "s":
                        gameLogic.SubtractionGame("Subtraction game");
                        break;
                    case "m":
                        gameLogic.MultiplicationGame("Multiplication game");
                        break;
                    case "d":
                        gameLogic.DivisonGame("Division game");
                        break;
                    case "q":
                        Console.WriteLine("Game Over! See you");
                        isGameOn = false;
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        Environment.Exit(1);
                        break;
                }
            } while (isGameOn);

        }
    }
}

