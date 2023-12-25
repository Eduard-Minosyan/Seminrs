
// int number = 9; //number = 9
// int result = number * number; // 81
// Console.Write (result);

// Console.Write ("Введите число: ");
// int input = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine (input + 1000);


// Команда "Console.ReadLine()" Позволяет вводить информацию пользователю.

// (=) - Положить значение в переменную
// (==) - Проверка а==5? (true, false)

// ЗАДАЧА_1  Проверка является ли первое число квадратом второго!!
Console.Write ("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber * secondNumber) // a является кв. от числа b
{
    Console.WriteLine ("Да, " + firstNumber + " является кв. от числа " + secondNumber);
}
else // a не является кв. от числа b
{
    Console.WriteLine ("НЕТ, " + firstNumber + " НЕ является кв. от числа " + secondNumber);
}

