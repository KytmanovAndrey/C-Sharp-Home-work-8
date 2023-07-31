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
    int rowStart = 0, rowFinish = rows - 1;
    int colStart = 0, colFinish = columns - 1;

    while (number <= rows * columns)
    {
        for (int i = colStart; i <= colFinish; i++)
        {
            array[rowStart, i] = number++;
        }
        rowStart++;
        for (int i = rowStart; i <= rowFinish; i++)
        {
            array[i, colFinish] = number++;
        }
        colFinish--;       
        for (int i = colFinish; i >= colStart; i--)
        {
            array[rowFinish, i] = number++;
        }
        rowFinish--;
        for (int i = rowFinish; i >= rowStart; i--)
        {
            array[i, colStart] = number++;
        }
        colStart++;
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