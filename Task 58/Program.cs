// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void Print2DArray(int[,] array)
{
    Console.WriteLine("Результирующая матрица будет:");
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

int[,] GetMatrixProduct(int[,] matrix, int[,] matrix2)
{
    int[,] matrixProduct = new int[matrix.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {          
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                matrixProduct[i,j] += matrix[i,k]*matrix2[k,j];
            }
        }
    }
    return matrixProduct;
}

int[,] CreatePrint2DArray(int rows, int columns)
{
    Console.WriteLine("Задана матрица:");
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

int rows = GetInput("Введите число строк первой матрицы: ");
int columns = GetInput("Введите число столбцов первой матрицы: ");
int rows2 = GetInput("Введите число строк второй матрицы: ");
int columns2 = GetInput("Введите число столбцов второй матрицы: ");
int[,] matrix = CreatePrint2DArray(rows, columns);
int[,] matrix2 = CreatePrint2DArray(rows2, columns2);
if (matrix.GetLength(1) != matrix2.GetLength(0)) Console.WriteLine("Некорректный ввод. Число столбцов первой матрицы должно быть равно числу строк второй матрицы.");
else 
{
    int[,] matrixProduct = GetMatrixProduct(matrix, matrix2);
    Print2DArray(matrixProduct);
}