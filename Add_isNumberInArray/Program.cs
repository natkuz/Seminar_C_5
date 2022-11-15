/* Дополнительно. Дан массив чисел. Напишите функцию, которая ищет заданное число в массиве и показывает нужный индекс в нем. 
При отсутствии числа возвращать -1. */

int FindNumberInMassive(int[] array, int number)
{
    int res = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            res = i;
        }
    }
    return res;
}

int[] massive = {3, 10, 16, 155, 2, 11};
System.Console.WriteLine(FindNumberInMassive(massive, 155));