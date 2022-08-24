/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int minSumRows = 0;
int sumRows = SumRowNumbers(matr, 0);
for (int i = 1; i < matr.GetLength(0); i++)
{
    int tmp = SumRowNumbers(matr,i);
    if (sumRows < tmp)
    {
        sumRows = tmp;
        minSumRows = i;
    }
}

int SumRowNumbers(int[,] matr, int i)
{
    int sumRows = matr[i, 0];
    for (int j = 1; j < matr.GetLength(1); j++)
    {
        sumRows += matr[i,j];
    }
    return sumRows;
}

Console.WriteLine("string with min sum is: " + (minSumRows + 1));