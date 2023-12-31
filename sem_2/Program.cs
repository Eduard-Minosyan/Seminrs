﻿// Семинар 2 Задача 1

// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого числа.
//Примеры
// а = 256 => 26
// а = 891 => 81

// Правило:
// "&&" - "И": яблоки и апельсины (и то и другое нужно купить.)
// "||" - "ИЛИ":  яблоки или апельсины(или купить что то одно или все вместе.)


// Console.Write("Введите  число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number >= 100 && number <= 999) //число трёхзначное
// {
//     int firstDigit = number / 100; // 274 / 100 = 2 
//     int thirdDigit = number % 10;  // 274 % 10 = 4
//     int result = firstDigit * 10 + thirdDigit;
//     Console.WriteLine($"Результат от числа {number} = {result}");

// }  //Интерполяция: (иной способ вывода) $"Значение переменной {firstDigit} = {чему то там}"

// else // Число не трёхзначное

// {
//     Console.WriteLine("Число НЕ трёхзначное");
// }


// Семинар 2 Задача 2

// Напишите программу, которпая принимает на вход трехзначное число
// и возводит вторую цифру этого числа в степень, равную третьей цифре.

// Примеры:
// 487 => 8 ^ 7 = 2 097 152
// 254 => 5 ^ 4 = 625
// 617 => 1 ^ 7 = 1

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number >= 100 && number <=999)
// {
//     int secondDigit = number / 10 % 10; // 487 / 10 % 10 = 48 % 10 = 8
//     int thirdDigit = number % 10; //487 % 10 = 7
//     // Math.Pow (5, 2) => 5 в 2 степени => 25
//     //int result = Convert.ToInt32(Math.Pow(secondDigit, thirdDigit)); // 1. Пример вывода с использованием Math.Pow
//     int result = (int)Math.Pow(secondDigit, thirdDigit); // 2. Пример вывода с использованием Math.Pow// else // Число не трёхзначное
//     //Console.WriteLine(result);
// Console.WriteLine($"Число {number}: {secondDigit}^{thirdDigit} = {result}");
// }

// else
// {
//      Console.WriteLine("Число НЕ трёхзначное");
// }

//Семинар 2 Задача 3

//Получите 3-ю цифру введенного числа слева (с начала)
// 1234567 => 3
// 7891 => 9
// 32 => Третьей цифры нет

// Console.Write("Введите число: ");
//  int number = Convert.ToInt32(Console.ReadLine());
//  int copyNumber = number;

// if (number < 100) // Третьей цифрын ет
// {
//    Console.WriteLine("Третьей цифры нет :)");
// }

// else
// {
//     while (number > 999)// Если в числе минимум 4 цифры делаем 
//     {
//         number /= 10; // number = number / 10
//         //a = a * 50: a *= 50
//         //a  = a - 450: a -= 450
//     }
//     Console.WriteLine($"Третья цифра от числа {copyNumber} = {number % 10}");
// }

//Семинар 2 Задача 4

//Получите 3-ю цифру введенного числа справа (с конца)
// 1234567 => 3
// 7891 => 9
// 32 => Третьей цифры нет


// Console.Write("Введите число: ");
//   int number = Convert.ToInt32(Console.ReadLine());
//   int copyNumber = number;

//   if (number < 100) // Третьей цифрын ет
// {
//     Console.WriteLine("Третьей цифры нет :)");
// }

// else // Число минимум трехзначное
// {
//     int digitCount =0; // Колитчество цифр, которое нужно убрать
//     //int digit =0; // Третья цифра справа
//     while (digitCount<2) // Отбрасываем 2 цифры
//     {
//         number /=10;
//         digitCount++;
//     }
//     Console.WriteLine(number % 10);
// }