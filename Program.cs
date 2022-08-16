// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for(int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + " ");
    }   
    Console.WriteLine("");
}

int CountPositiveNum(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
    return count;
}
/*
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное возможное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);
int result = CountPositiveNum(array);
Console.WriteLine($"Чисел больше нуля - {result}.");
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
Console.Write("Введите значение B1 ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

    //k1 * x + b1 = k2 * x + b2;
    //k1 * x - k2 * x + b1 -b2 = 0;
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;


Console.Write($"точка перечесения прямых с заданными параметрами: {x} {y} ");
