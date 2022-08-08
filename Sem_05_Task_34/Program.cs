/*  Задайте массив заполненный случайными положительными трёхзначными числами. 
* Напишите программу, которая покажет количество чётных чисел в массиве.
* [345, 897, 568, 234] -> 2
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

int ShowEvenNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0) count++;
    
    return count;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible three-digit value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible three-digit value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array1 = CreateRandomArray(size, min, max);
ShowArray(array1);

Console.WriteLine("Count even elements in three-digit is " + ShowEvenNumbers(array1));

