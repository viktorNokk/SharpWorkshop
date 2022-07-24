/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void Cube(int n)
{
    for (int i = 1; i <= n; i++)
    {
        int cube = i * i * i;
        Console.Write(cube + ", ");
    }
}

Console.Write("Input N: ");
int currentN = Convert.ToInt32(Console.ReadLine());
Cube(currentN);






