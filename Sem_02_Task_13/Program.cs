//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.Write("Введите число: ");
string number = Console.ReadLine();
string str = number.ToString();
Console.WriteLine(str[2]);

if (number.Length<2) Console.WriteLine("Нет 3й цифры");












