/* Напишите программу, которая на вход принимает позиции элемента либо значение элемента в двумерном массиве, 
и возвращает значение либо индекс этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
4 -> такой элемент есть и его индекс 0, 1 (идеально было б найти все вхождения этого элемента)
2, 3 -> такой элемент есть и равен 4
5, 5 -> такой элемент отсутствует
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
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int FindNumMatr(int[,] matr, int positionX, int positionY)
{
    int num = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == positionX && j == positionY)
            {
                num = matr[i,j];
            }
        }
    }
    return num;
}

Console.Write("Input rows in matrix: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input columns in matrix: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Input position X: ");
int positionX = Convert.ToInt32(Console.ReadLine());
Console.Write("Input position Y: ");
int positionY = Convert.ToInt32(Console.ReadLine());


int[,] matrix = new int[row, col];
//PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);

if (FindNumMatr(matrix, positionX, positionY) > 0)
    Console.WriteLine("Value at position (X;Y): " + FindNumMatr(matrix, positionX, positionY));
else
    Console.WriteLine("There is no such value!");
