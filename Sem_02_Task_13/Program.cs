//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//Console.Clear();

void thirdNumber()
{
    while (true)
    {
        int num;

        Console.Write("Input number: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (num < 99)
        {
            Console.WriteLine("third number is missing");
        }
        else
        {
            Console.WriteLine("third number is: " + num.ToString()[2]);
        }
    }
}

thirdNumber();































