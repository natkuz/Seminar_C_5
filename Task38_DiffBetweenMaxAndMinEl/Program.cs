//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
//[3 7 22 2 78] -> 76

double FindMinElementOfArray(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double FindMaxElementOfArray(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}


double[] collection = {3.5, 7.0, 6.8, 15.1, -7.7, 3.3};
System.Console.WriteLine();
double minNumber = FindMinElementOfArray(collection);
double maxNumber = FindMaxElementOfArray(collection);
System.Console.WriteLine(maxNumber - minNumber);
