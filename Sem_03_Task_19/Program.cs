/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
14212 -> нет
12821 -> да
23432 -> да
*/

void Palindrome()
{
    int num;

    Console.Write("Input five-digit number: ");
    num = Convert.ToInt32(Console.ReadLine());

    if (num.ToString()[0] == num.ToString()[4] && num.ToString()[1] == num.ToString()[3])
    {
        Console.WriteLine("Yes");
    }
    else if(num > 99999 || num < 9999)
    {
        Console.WriteLine("The numers is not five-digit");
    }
    else
    {
        Console.WriteLine("No");
    }
}

Palindrome();


