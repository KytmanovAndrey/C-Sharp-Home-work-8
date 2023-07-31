// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void Print2DArray(int[,] array)
{
    Console.WriteLine("В итоге получается вот такой массив:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(" " + array[i, j].ToString("D2"));
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Create2DArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int number = 1;
    int Top = 0, Bottom = rows - 1;
    int Left = 0, Right = columns - 1;

    while (number <= rows * columns)
    {
        for (int i = Left; i <= Right; i++)
        {
            array[Top, i] = number++;
        }
        Top++;
        for (int i = Top; i <= Bottom; i++)
        {
            array[i, Right] = number++;
        }
        Right--;       
        for (int i = Right; i >= Left; i--)
        {
            array[Bottom, i] = number++;
        }
        Bottom--;
        for (int i = Bottom; i >= Top; i--)
        {
            array[i, Left] = number++;
        }
        Left++;
    }      
    return array;
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = GetInput("Введите число строк: ");
int columns = GetInput("Введите число столбцов: ");
int[,] array = Create2DArray(rows, columns);
Print2DArray(array);