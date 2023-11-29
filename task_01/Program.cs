// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].
Console.Clear();// После запуска программы очищает командную строку (cmd.exe)
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 101); 
    Console.Write($"{array[i]}\t");  
}
// Console.WriteLine(string.Join(",", array));//Еще один из вариантов вывода массива на экран.
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 19 && array[i] < 91)
    {
        count++;
    }
}
Console.WriteLine("");
Console.WriteLine($"Количество элементов массива лежащих в интервале [20,90]={count}");