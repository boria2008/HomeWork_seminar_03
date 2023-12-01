// Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, 
// состоящий из цифр этого числа. Старший разряд числа должен располагаться на 0-м индексе массива,
// младший – на последнем. Размер массива должен быть равен количеству цифр.
Console.Clear();
int number = new Random().Next(1, 100001);
Console.WriteLine(number);
int temp = number;
int count = 0;
while (number > 0)
{
    number /= 10;
    count++;
}
int[] array = new int[count];
for (int i = 0; i < count - 1; i++)
{
    array[i] = temp % 10;
    temp /= 10;
}
array[count - 1] = temp;
for (int i = 0, j = count - 1; i < count / 2; i++, j--)
{
    int temporary = array[i];
    array[i] = array[j];
    array[j] = temporary;
}
Console.WriteLine($"[{string.Join("\t", array)}]");