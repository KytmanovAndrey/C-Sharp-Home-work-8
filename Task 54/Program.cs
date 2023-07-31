// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void Print2DArray(int[,] array)
{
    Console.WriteLine("В итоге получается вот такой массив:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(" " + array[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void DescendingSortRows(int[,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1) - 1; i++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[k, j] < array[k, j + 1])
                {
                    int temp = array[k, j];
                    array[k, j] = array[k, j + 1];
                    array[k, j + 1] = temp;
                }

            }
        }
    }
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
DescendingSortRows(array);
Print2DArray(array);