/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

// sum 4 -8 = 4+5+6+7+8
Console.Clear();
int ShowSum(int m, int n)
{
    if(n > m)
    {
        return n + ShowSum(m, n - 1);
    }
    else return n;
}
Console.WriteLine(ShowSum(4,8));
Console.WriteLine(ShowSum(1,15));
Console.ReadKey();
