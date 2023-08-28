// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}

int SumElemRow(int[,] matrix, int rowIndex)
{
    int rowSum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        rowSum += matrix[rowIndex, j];
    }
    return rowSum;
}

int NumberMinSum(int[,] matrix)
{
    int minSum = int.MaxValue;
    int minSumRowIndex = -1;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int rowSum = SumElemRow(matrix, i);

        if (rowSum < minSum)
        {
            minSum = rowSum;
            minSumRowIndex = i;
        }
    }

    return minSumRowIndex;
}

int[,] matrix = CreateMatrixRndInt(3, 4, 0, 10);
Console.WriteLine("Задан массив:");
PrintMatrix(matrix);

int minSumRowIndex = NumberMinSum(matrix);
Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRowIndex + 1} строка");
