// Task1 
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int minvalue, int maxvalue)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(minvalue, maxvalue + 1);
    }

    return array;
}

int GetEvenCount(int[] array)
{
    int count = 0; 
    for(int i =0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] arr = GetArray(4, 100, 999);
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine($"Колличество четных элементов массива {GetEvenCount(arr)}");


//Task2
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int minvalue, int maxvalue)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(minvalue, maxvalue + 1);
    }

    return array;
}

int SumOddPositionElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int[] arr = GetArray(4, 1, 50);
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях {SumOddPositionElements(arr)}");


//Task3
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GetDoubleArray(int size, int minvalue, int maxvalue)
{
    double[] array = new double[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(minvalue, maxvalue + 1);
    }

    return array;
}

double DiffMaxMin(double[] array)
{
    double min = array[0];
    double max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return max - min;
}

double[] arr = GetDoubleArray(5, 1, 100);
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine($"Разница между максимальным и минимальным элементом массива - {DiffMaxMin(arr)}");
