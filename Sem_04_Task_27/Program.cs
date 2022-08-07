/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int SumValue(int value)
{
    int sum = 0;
    while (value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }

    return sum;
}

Console.Write("Input value: ");
int val = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sum value is: " + SumValue(val));


// int a = 123;

// Console.WriteLine(a % 10);
// Console.WriteLine(a / 10);

