// Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

int [,] matrix = new int [4,4];

Console.WriteLine("Заданный двумерный массив:");

for (int i=0; i<matrix.GetLength(0); i++)
{
    for (int j=0; j<matrix.GetLength(1); j++)
    {
        matrix [i,j] = new Random().Next(0,21);
        Console.Write(matrix[i,j]+"\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Массив с упорядоченными строками: ");

int [,] tempMatrix = new int [4,4];

for (int i=0; i<matrix.GetLength(0); i++)
{
    for (int j=0; j<matrix.GetLength(1); j++)
    {
        int maxNum=matrix[0,j];
    

    }
    
}
