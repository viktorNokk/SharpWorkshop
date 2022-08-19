/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int  i = 0;  i < matr.GetLength(0);  i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1,10);
        }
    }
}

void AverageColumns(int[,] matr)
{
    double sum = 0;

    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            sum += matr[i, j];
        }
        Console.Write($"{ sum / matr.GetLength(0)} ");
        sum = 0;
    }
}

Console.Write("Input rows in matrix: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns in matrix: ");
int col = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[row, col];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine("Quantity of numbers in a column: " + matrix.GetLength(0));
AverageColumns(matrix);
