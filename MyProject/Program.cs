using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int number = rand.Next (1, 101);

            int tryingToGuess = 0;

            int triesLeft = 10;

            int tries = 0;
            while (tryingToGuess != number)
            {
                tries++;
                System.Console.WriteLine($"Пожалуйста введите ваше число от 1 до 100, у вас осталось {triesLeft} попыток");
                triesLeft--;
                tryingToGuess = int.Parse(Console.ReadLine());
                if (tryingToGuess > number)
                {
                    Console.WriteLine("Ваше число больше загаданного");
                }
                else if (tryingToGuess < number)
                {
                    System.Console.WriteLine("Ваше число меньше загаданного");
                }
                if (tries >= 10 && tryingToGuess != number)
                {
                    Console.WriteLine("Вы проиграли!");
                    return;
                }
            }
System.Console.WriteLine($"Поздравляю, вы угадали число за {tries} попыток!");
Console.ReadLine();


        }
}   
}
