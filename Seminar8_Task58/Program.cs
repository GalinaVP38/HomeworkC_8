// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:

int[,] matrix = new int[2, 2];
int[,] secondMatrix = new int[2, 2];
int[,] resultMatrix = new int[2, 2];

if (matrix.GetLength(0) != secondMatrix.GetLength(1))
{
    Console.WriteLine("Такие матрицы нельзя умножать.");
}

void PrintMatrix (int [,] matrix)
{
   for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
            Console.Write(matrix[i,j]+"\t");
        }
        Console.WriteLine();
    } 
}
Console.WriteLine("Первая матрица: ");
PrintMatrix(matrix);
Console.WriteLine("Вторая матрица: ");
PrintMatrix(secondMatrix);

Console.WriteLine("Матрица после произведения двух матриц: ");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < secondMatrix.GetLength(1); j++)
    {
        for (int k = 0; k < secondMatrix.GetLength(0); k++)
        {
            resultMatrix[i, j] += matrix[i, k] * secondMatrix[k, j];
        }
        Console.Write(resultMatrix[i,j]+"\t");
    }
    Console.WriteLine();
}
