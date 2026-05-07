// See https://aka.ms/new-console-template for more information
int[,] myArray = new int[5, 6];

Random random = new Random();

for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        myArray[i, j] = random.Next(-100, 100);
    }
    Console.WriteLine();
}

for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        Console.Write(myArray[i, j] + "\t");
    }
    Console.WriteLine();
}

for (int row = 0; row < myArray.GetLength(0); row++) // Перебор строк
{
    for (int i = 0; i < myArray.GetLength(1); i++) // Левый элемент для сравнения
    {
        for (int j = i + 1; j < myArray.GetLength(1); j++) // Правый элемент
        {
            if (myArray[row, i] > myArray[row, j]) // Сортировка по убыванию
            {
                int temp = myArray[row, i];
                myArray[row, i] = myArray[row, j];
                myArray[row, j] = temp;
            }
        }
    }
}
Console.WriteLine();
for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        Console.Write(myArray[i, j] + "\t");
    }
    Console.WriteLine();
}
Console.ReadLine();