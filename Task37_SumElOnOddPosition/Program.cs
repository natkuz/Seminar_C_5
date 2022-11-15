/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 

Решение, если считать, что позиция элемента нечетная, когда у элемента нечетный индекс*/

int[] GetArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int i = 1; i < length; i++)
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

int SumElementsOnOddPosition(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;    
}

int[] collection = GetArray(4, 0, 15);
PrintArray(collection);
System.Console.WriteLine();
int res = SumElementsOnOddPosition(collection);
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {res}");