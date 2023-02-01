namespace Math_Game
{
	public class Helpers
	{
        static List<string> games = new();

        internal static void GetGames()
        {
            Console.Clear();
            Console.WriteLine("Games History: ");
            Console.WriteLine("------------------------");
            foreach (var game in games)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("------------------------\n");
            Console.WriteLine("Press ant key to go back to Main Menu.");
            Console.ReadLine();
        }

        internal static void AddToHistory(object gameScore, string gameType)
        {
            games.Add($"{DateTime.Now} - {gameType}: {gameScore} pts");
        }

        internal static int[] GetDivisionNumber()
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
    }
}

