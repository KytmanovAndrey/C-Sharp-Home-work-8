// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FindNumberOfMinRowSum(int[,] array)
{
    int sum = 0;
    int sumOfNextRow = 0;
    int number = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (i == 0) sumOfNextRow = sum;
        if (sum < sumOfNextRow) 
        {
            number = i;
            sumOfNextRow = sum;
        }
        sum = 0;
    }
    Console.WriteLine($"номер строки с наименьшей суммой элементов: {number + 1} строка");
}

int[,] CreatePrint2DArray(int rows, int columns)
{
    Console.WriteLine("Задан массив:");
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(" " + array[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return array;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = GetInput("Введите число строк: ");
int columns = GetInput("Введите число столбцов: ");
int[,] array = CreatePrint2DArray(rows, columns);
FindNumberOfMinRowSum(array);