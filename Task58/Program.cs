// Задача 58: Задайте две матрицы.
//  Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int rows1 = 3;
int cols1 = 3;
int rows2 = 3;
int cols2 = 3;


int[,] matrix1 = CreateMatrixRndInt(rows1, cols1, 1, 5);
int[,] matrix2 = CreateMatrixRndInt(rows2, cols2, 1, 5);

Console.WriteLine("Первый массив:");
PrintMatrix(matrix1);

Console.WriteLine("Второй массив:");
PrintMatrix(matrix2);

if (cols1 != rows2)
{
    Console.WriteLine("Умножение невозможно из-за неправильных размеров массива.");
    return;
}


int[,] resultMatrix = new int[rows1, cols2];

for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < cols2; j++)
    {
        int sum = 0;
        for (int k = 0; k < cols1; k++)
        {
            sum += matrix1[i, k] * matrix2[k, j];
        }
        resultMatrix[i, j] = sum;
    }
}

Console.WriteLine("Результирующий массив:");
PrintMatrix(resultMatrix);
