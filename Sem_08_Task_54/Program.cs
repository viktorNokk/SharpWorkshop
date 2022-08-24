/* Задайте двумерный массив. Напишите программу, которая упорядочит по 
убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
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
            matr[i, j] = new Random().Next(-50,50);
        }
    }
}

int[,] MatrixBubleSortDecrease(int[,] matr)
{
    for (int  i = 0;  i < matr.GetLength(0);  i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1) - 1; k++)
            {
                if (matr[i,k] < matr[i, k + 1])
                {
                    int tmp = matr[i, k + 1];
                    matr[i, k + 1] = matr[i, k];
                    matr[i, k] = tmp;
                }
            }
        }
    }
    return matr;
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
MatrixBubleSortDecrease(matrix);
Console.WriteLine("Print bublesorted of matrix by decrease: ");
PrintArray(matrix);

