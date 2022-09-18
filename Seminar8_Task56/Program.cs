// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [rows,columns];

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

int [] array = new int [rows];

Console.WriteLine("Одномерный массив из сумм строк");
for (int i=0; i<matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j=0; j<matrix.GetLength(1); j++)
    {
        sum+=matrix[i,j];
    }
    array [i] = sum;
}
Console.WriteLine("[{0}]", String.Join(", ", array));

int index = 0;
int minNum = array [0];
for (int i=0; i <array.Length-1; i++)
{
    if (array[i]<array[i+1] && array[i]<=minNum) 
    {
        index=i;
        minNum=array[i];
    }
}
Console.WriteLine($"Строка с наименьшей суммой элементов: {index+1} строка");