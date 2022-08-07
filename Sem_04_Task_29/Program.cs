/* Напишите программу, которая создает массив из введенных через запятую цифр и выводит этот массив на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

*/

Console.Clear();
Console.Write("Input numbers of array elements: ");
int elementsNumber = Convert.ToInt32(Console.ReadLine());

int[] newArray = new int[elementsNumber]; 

for (int i = 0; i < newArray.Length; i++)
{
    Console.Write($"Input array element at index [{i}]: ");
    newArray[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("\nArray output: ");

for (int i = 0; i < newArray.Length; i++)
{
    Console.Write(newArray[i] + ", ");
}



