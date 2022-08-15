/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
* m = 3, n = 4.
* 0,5 7 -2 -0,2
* 1 -3,3 8 -9,9
* 8 7,8 -7,1 9
*/

double[,] Create2dArray(double rows, double columns, double minValue, double maxValue)
{
    double[,] newArray = new double[rows, columns];

    for(int i = 0; i < rows; i++);
        for(int j = 0; j < columns; j++)
            newArray[i, j] = new Random().NextDouble(minValue, maxValue + 1);

    return newArray;    
}

void Show2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

Console.Write("Input m rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
double min = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Input max possible value: ");
double max = Convert.ToDouble(Console.ReadLine()); 

int[,] myArray = Create2dArray(m, n, min, max);
Show2dArray(myArray);


/*
Console.Write("Input m rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n columns: ");
int n = Convert.ToInt32(Console.ReadLine());


double[,] a = new double[m, n];

//Random random = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        a[i, j] = new Random().NextDouble()*10; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        Console.Write("{0,6:F2}", a[i, j]);
    }
    Console.WriteLine();
}
*/

