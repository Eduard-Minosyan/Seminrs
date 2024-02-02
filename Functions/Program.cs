// тип_метода ИмяМетода (пар1, пар2)
// string - массив char-ов
// char ('+', '-')
// int Calculate(int a, int b, char sign)
// {
// if (sign == '+')
// {
// return a + b;
// }
// else if (sign == '-')
// {
// return a - b;
// }
// else if (sign == '*')
// {
// return a * b;
// }
// else
// {
// Console.WriteLine("Введено неизвестное выражение :(");
// return 0;
// }
// }
// // Вызов функции
// int res = Calculate(100, 350, '*');
// Console.WriteLine($"res: {res}");
// Console.WriteLine(Calculate(2, 3, '+'));
// Console.WriteLine(Calculate(20, 30, '*'));
// Console.WriteLine(Calculate(20, 30, '-'));
// Console.WriteLine(Calculate(20, 30, ','));



// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

// size = размер, minRange - мин. число в рандоме,
// maxRange - макс число в рандоме
// int[] CreateArray(int size, int minRange, int maxRange)
// {
// int[] array = new int[size]; // Массив на size эл
// for (int i = 0; i < array.Length; i++)
// {
// array[i] = new Random().Next(minRange, maxRange + 1);
// }
// return array;
// }

// int GetCount(int[] arr)
// {
// int count = 0;
// foreach (int number in arr)
// {
// if (number % 7 == 0 && number % 10 == 1)
// {
// count++;
// }
// }
// return count;
// }

// Console.Write("Введите размер массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(N, 0, 100);
// // array - массив на N элементов,
// // каждый элемент - число: [0,100]
// Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
// Console.WriteLine($"Total: {GetCount(array)}");



// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

int[] CreateArray(int size)
{
int[] array = new int[size]; // Массив на size эл
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(0, 10);
// 0, 9
}
return array;
}
Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(N);
if (array[0] == 0 || N > 8)
{
Console.WriteLine("Размер > 8 эл, или 0 элемент = 0");
return;
}
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
int ConvertArrayToInteger(int[] array)
{
int result = 0;
// 294
for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
{
result = result + array[i] * (int)Math.Pow(10, j);
}
return result;
}
Console.WriteLine($"Число: {ConvertArrayToInteger(array)}");