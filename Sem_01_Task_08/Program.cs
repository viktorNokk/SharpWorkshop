//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.Write("Input N: ");
int N = Convert.ToInt32(Console.ReadLine());

int result = 1;

while (result <= N)
{
    if (result % 2 == 0)
    {
        Console.Write(result);
    }
    result++;
}
