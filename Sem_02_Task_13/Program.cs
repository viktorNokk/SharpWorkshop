//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int SomeDigital(int num)
{
    int some = num %10;
    return some;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); //убрать to int32

// проверить правильность строки (проверка на то, что это действительно число)
// проверка на длину if (number.length > 2)
// return number[1]

int dig = SomeDigital(number);

Console.WriteLine($"третье число в {number} это {dig}");
