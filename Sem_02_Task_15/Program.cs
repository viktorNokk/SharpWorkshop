//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.Clear();
bool Day(int number)
{
    if (number >= 1 && number < 6) return false;
    else return true;
    
}

Console.Write("Введите день недели (от 1 до 7): ");
int num = Convert.ToInt32(Console.ReadLine());

bool newDay = Day(num);
Console.WriteLine(newDay);










// Console.Write("Введите день недели: ");
// int number = Convert.ToInt16(Console.ReadLine());

// if (number >= 1 && number < 6)
// {
//     Console.WriteLine("Нет, будний день");
// }
// else if (number > 7)
// {
//     Console.WriteLine("Нет такого дня");
// }
// else
// {
//     Console.WriteLine("Да, выходной");
// }





