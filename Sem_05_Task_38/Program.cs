/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
* [3 7 22 2 78] -> 76
*/

int[] CreateArray(int size)
{
    int[] newArray = new int[size];

    Console.WriteLine("Creating array here:");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element: " );
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return newArray;   
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int FindMax(int[] array)
{
    int max = array[0];

    for (int i = 0; i < array.Length; i++)
        if(array[i] > max) max = array[i];
   
    return max;
}

int FindMin(int[] array)
{
    int min = array[0];

    for (int i = 0; i < array.Length; i++)
        if(array[i] < min) min = array[i];
   
    return min;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array2 = CreateArray(size);
int result = FindMax(array2) - FindMin(array2);

ShowArray(array2);
Console.WriteLine("==============");

Console.WriteLine($"Max is {FindMax(array2)} \nMin is {FindMin(array2)} \nresult Max - Min is " + result);

