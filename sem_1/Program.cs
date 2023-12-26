
// int number = 9; //number = 9
// int result = number * number; // 81
// Console.Write(result);

// Console.Write("Введите число: ");
// int input = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(input + 1000);


// Команда "Console.ReadLine()" Позволяет вводить информацию пользователю.

// (=) - Положить значение в переменную
// (==) - Проверка на равенство а==5? (true, false)

// ЗАДАЧА_1  Проверка является ли первое число квадратом второго!!
// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber == secondNumber * secondNumber) // a является кв. от числа b
// {
//     Console.WriteLine("Да, " + firstNumber + " является кв. от числа " + secondNumber);
// }
// else // a не является кв. от числа b
// {
//     Console.WriteLine("НЕТ, " + firstNumber + " НЕ является кв. от числа " + secondNumber);
// }

// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// //N = 4, 4 * (-1) = -4
// if (N < 0)
// {
//     Console.WriteLine("Введено отрицательное число N");
//     N = N * -1;
// }

// int negativeN = N * -1; // -4


// while (negativeN <= N)
// {
//     Console.Write(negativeN + " \t ");
//     negativeN++; // negativeN++ это (negativeN = negativen + 1)
// }

// а-- Декременет: а = а - 1.
// а++ Инкремент: а = а + 1.

// int a = 10;
// a--;
// Console.WriteLine(a);


// Задача нахождения 3-го числа слева 
// Console.Write("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number <= 99) return;
// while (number > 999)
// {
//     number /= 10; //number = number / 10
// }

// Console.WriteLine(number % 10);

// Задача 1 семинара 1
// Создать программу которая проверяет какое из двух чисел является большее 
// и выводит его на экран а так же выводит на экран числа равные по значению

// Console.Write("Input first number: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input second number: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber < secondNumber)
// {
//     Console.WriteLine("Первое число " + "`" + firstNumber + "`" + " меньше чем второе число " + "`" + secondNumber + "`");
// }
// else

//          if (firstNumber > secondNumber)
// {
//     Console.WriteLine("Первое число " + "`" + firstNumber + "`" + " больше чем второе число " + "`" + secondNumber + "`");
// }




// else
// {
//     Console.WriteLine("Введенные числа равны " + "`" + firstNumber + "`");
// }

// Задача 2 семинара 1 Проверка чисел на четность
// Console.Write("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number % 2 == 0)
// {
//     Console.WriteLine("Число" + " `" + number + "` " + "чётное");
// }

// else
// {
//     Console.WriteLine("Число" + " `" + number + "` " + "нечётное");
// }
// Задача 2 семинара 1 Ввод 3-х чисел и нахождение максимального из них.

// Console.Write("Введите первое число ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число ");
// int c = Convert.ToInt32(Console.ReadLine());

// if (a > b && a > c)
// {
//     Console.WriteLine(a);
//     return (a);
// }
// else

//   if (a < b && b > c)
// {
//     Console.WriteLine(b);
//     return (b);
// }
// else
// {
//     Console.WriteLine(c);
//     return (c);
// }

// Задача 4 семинар 1 Принимает число N и выводит все четные числа от 1 до N
// включительно разделенные знаком табуляции.
    Console.Write("Введите число ");
  int n = Convert.ToInt32(Console.ReadLine());
  int i = 1;
  while (i <= n)
  {
    
    if (i % 2 == 0)
    Console.Write(i +"\t");
    i++;
  }