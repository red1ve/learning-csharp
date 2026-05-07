char[,] Myarray = 
{
    {'1','2','3'},
    {'4','5','6'},
    {'7','8','9'}
};

char currentPlayer = 'X'; // Переменная для текущего игрока

while (true)
{
    Console.Clear(); // Очищаем экран каждый раз
    
    // Рисуем поле
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(Myarray[i, j] + " ");
        }
        Console.WriteLine();
    }

    Console.WriteLine($"\nСейчас ходит: {currentPlayer}");
    Console.WriteLine($"Выберите число, чтобы поставить '{currentPlayer}'");
    
    string guessingNumber = Console.ReadLine();

    // Проверяем, что ввод не пустой
    if (!string.IsNullOrEmpty(guessingNumber))
    {
        char choise = guessingNumber[0];
        bool moveMade = false; // Флаг: был ли сделан ход

        // Ищем введенную цифру в массиве
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                // Сравниваем с текущей ячейкой [i, j]
                if (Myarray[i, j] == choise)
                {
                    Myarray[i, j] = currentPlayer;
                    moveMade = true; // Помечаем, что ход успешный
                }
            }
        }

        // Если ход сделан — меняем игрока
        if (moveMade)
        {
            if (currentPlayer == 'X') currentPlayer = 'O';
            else currentPlayer = 'X';
        }
    }
}
