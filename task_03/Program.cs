// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью.
//  Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
double[] array = new double[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = Math.Round(new Random().NextDouble() * new Random().Next(1, 100), 3);
}
Console.WriteLine($"[{string.Join(";\t", array)}]");
double min = array[0];
double max = array[1];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
    else if (array[i] > max)
    {
        max = array[i];
    }
}
Console.WriteLine($"min={min},\tmax={max}");
Console.WriteLine($"diff={Math.Round(max - min, 3)}");