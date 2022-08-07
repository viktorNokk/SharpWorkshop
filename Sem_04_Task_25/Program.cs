/* 
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int Exponenta(int a, int b)
{
    int expo = 1;

    for (int i = 0; i < b; i++)
    {
        expo = expo * a;
    }

    return expo;
}

Console.Write("Input A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Input B: ");
int B = Convert.ToInt32(Console.ReadLine());

int result = Exponenta(A, B);

Console.WriteLine($"Num {A} exponenta {B} is {result}");








