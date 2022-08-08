/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
* [3, 7, 23, 12] -> 19
* [-4, -6, 89, 6] -> 0
*/

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    
    return newArray;
}

void ShowArray(int[] array)

{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int SumOddNumbers(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
        if(array[i] % 2 != 0) 
            sum = sum + array[i];

    return sum;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array1 = CreateRandomArray(size, min, max);
ShowArray(array1);

Console.WriteLine("Sum of odd numbers is " + SumOddNumbers(array1));