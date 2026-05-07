using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] myArray = {{3,-3},{21,-32}};

            int sumOfPositive = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (myArray[i,j]<0)
                    {
                        myArray[i,j] = 0;
                    }
                    else
                    {
                        sumOfPositive += myArray[i,j];
                    }
                }
            }

            Console.WriteLine("Новый массив;");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(myArray[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма положительных значений массива = {sumOfPositive}");
        }
    }
}