/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

int[] GetArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        System.Console.Write(item + " ");
    }
}

int GetEvenNumberOfArray(int[] array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            res = res + 1;
        }
    }
    return res;
}

int[] massive = GetArray(5, 100, 500);
PrintArray(massive);
System.Console.WriteLine();
int result = GetEvenNumberOfArray(massive);
System.Console.WriteLine(result);
