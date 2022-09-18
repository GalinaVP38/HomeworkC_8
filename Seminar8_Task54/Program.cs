// Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

int [,] matrix = new int [4,4];

Console.WriteLine("Заданный двумерный массив:");

for (int i=0; i<matrix.GetLength(0); i++)
{
    for (int j=0; j<matrix.GetLength(1); j++)
    {
        matrix [i,j] = new Random().Next(0,11);
        Console.Write(matrix[i,j]+"\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Массив с упорядоченными строками: ");

int [,] twoArray = new int [4,4];

for (int i=0; i < matrix.GetLength(0); i++)
{
    for (int j=0; j<matrix.GetLength(1); j++)
    {
         for (int k = 0; k < matrix.GetLength(1)-1; k++)
         {
            for (int l=0; l < matrix.GetLength(1)-1; l++)
            {
                if (matrix[i, l] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, l];
                    matrix[i, l] = temp;
                }
            }
         }
         Console.Write(matrix[i,j]+"\t");           
    }
   Console.WriteLine(); 
}
