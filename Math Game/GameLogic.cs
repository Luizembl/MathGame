using Math_Game.Models;
namespace Math_Game
{
	internal class GameLogic
	{
        internal void AdditionGame(string message)
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

                result = Helpers.ValidateResult(result);

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

            Helpers.AddToHistory(score, GameType.Addition);
        }

        internal void SubtractionGame(string message)
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

                result = Helpers.ValidateResult(result);

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

            Helpers.AddToHistory(score, GameType.Subtraction);
        }

        internal void DivisonGame(string message)
        {
            var score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);

                var divisionNumbers = Helpers.GetDivisionNumber();
                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();

                result = Helpers.ValidateResult(result);

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

            Helpers.AddToHistory(score, GameType.Division);
        }

        internal void MultiplicationGame(string message)
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

                result = Helpers.ValidateResult(result);

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

            Helpers.AddToHistory(score, GameType.Multiplication);
        }

    }
}

