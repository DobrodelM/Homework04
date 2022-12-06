/* Задача 29.
Напишите программу, которая задаёт
массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] generateRandomArray(int length, int start, int finish)
{
int[] resultArray = new int[length];
for (int i = 0; i < length; i++)
{
resultArray[i] = new Random().Next(start, finish + 1);
}
return resultArray;
}

void printArray(int[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i]);
if(i < array.Length - 1)
{
Console.Write(", ");
}
}
Console.WriteLine("]");
}

int GetLengthFromUser(string message)
{
    int result = 0;
    Console.WriteLine(message);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int length = GetLengthFromUser("Введите количество элементов в массиве: ");
int[] array = generateRandomArray(length, -99, 99);
printArray(array);
