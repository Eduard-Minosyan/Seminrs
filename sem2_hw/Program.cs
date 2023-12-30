// Задача 1 Семинар 2

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int firstNumber = 7;
// int secondNumber = 23;

// if (number % firstNumber == 0 && number % secondNumber == 0)
// {
//     Console.WriteLine($"Да число {number}  кратно 7 и 23");
// }
// else
// {
//     Console.WriteLine("Нет число " + number + " не кратно 7 и 23");
// }


// Задача 2 Семинар 2

// Console.Write("Введите число x: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0)  // первая четверть
// {
//     Console.WriteLine("Первая координатная четверть");
// }
// else
// {
//     if (x < 0 && y > 0)  // вторая четверть
//     {
//         Console.WriteLine("Вторая координатная четверть");
//     }
//     else
//     {
//         if (x < 0 && y < 0) // третья четверть
//         {
//             Console.WriteLine("Третья координатная четверть");
//         }
//         else
//         {
//            if (x > 0 && y < 0) // четвертая четверть
//             {
//                 Console.WriteLine("Четвертая координатная четверть");
//             }

//         }

//     }

// }



// Задача 3 Семинар 2

Console.Write("Введите двухзначное  число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 10 && number <= 99)
{
    int firstNumber = number / 10;
    int secondNumber = number % 10;
   
     if (firstNumber > secondNumber)
        {
        Console.WriteLine($"Максимальная цифра числа {number} является {firstNumber}");
        }
        
        else
        {
        Console.WriteLine($"Максимальная цифра числа {number} является {secondNumber}");
        }
    }
else
{
    Console.WriteLine("Введено неверное чиcло");
}
    