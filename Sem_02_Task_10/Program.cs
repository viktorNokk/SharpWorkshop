//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int SomeDigital(int num)
{
    int some = num %10;
    return some;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int dig = SomeDigital(number);

Console.WriteLine($"второе число в {number} это {dig}");













// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// while (number >= 100 && number < 1000)
// {
//     number = number/10;
//     if (number<100)
//     {
//         Console.WriteLine("Вторая (с начала) цифра : {0}", number.ToString().ToCharArray()[1]);
//     }
//     else
//     {
//         Console.WriteLine("Число не трехзначное: ");
//     }
// }