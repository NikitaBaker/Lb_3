using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        bool playAgain = true;

        while (playAgain)
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 10);

            Console.WriteLine("Програма загадала число від 1 до 10. Спробуйте його вгадати!");

            bool guessed = false;
            while (!guessed)
            {
                Console.Write("Ваше число: ");
                string userInput = Console.ReadLine();


                if (int.TryParse(userInput, out int userGuess))
                {
                    if (userGuess < secretNumber)
                    {
                        Console.WriteLine("Ваше число менше за загаданого. Спробуйте ще раз!");
                    }
                    else if (userGuess > secretNumber)
                    {
                        Console.WriteLine("Ваше число більше за загаданого. Спробуйте ще раз!");
                    }
                    else
                    {
                        Console.WriteLine($"Вітаємо! Ви вгадали число {secretNumber}!");
                        guessed = true;
                    }
                }
                else
                {
                    Console.WriteLine("Будь ласка, введіть число.");
                }
            }

            Console.Write("Бажаєте спробувати знову? (так/ні): ");
            string playAgainInput = Console.ReadLine()?.ToLower();
            playAgain = playAgainInput == "так";
            Console.Clear();
        }

        Console.WriteLine("Дякую за гру! До побачення!");
    }
}
