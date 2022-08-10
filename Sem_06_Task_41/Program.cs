/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
* 0, 7, 8, -2, -2 -> 2
* 1, -7, 567, 89, 223-> 3
*/

int[] CreateArray(int size)
{
    int[] newArray = new int[size];

    Console.WriteLine("Creating array here:");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element: " ); // чтобы начать с 1 а не с 0
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return newArray;   
}

int CountPositiveNum(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }

    return count;
}

void ShowArray(int[] array)

{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array2 = CreateArray(size);
ShowArray(array2);

int countArr = CountPositiveNum(array2);

Console.WriteLine("Count of pissitive numbers in array  is " + countArr);





