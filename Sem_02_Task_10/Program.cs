//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.Write("Введите число: ");
string number = Console.ReadLine();
string str = number.ToString();
Console.WriteLine(str[2]);












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