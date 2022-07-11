//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.Write("Input First number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input Second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input Third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;

Console.Write("max = ");
Console.WriteLine(max);