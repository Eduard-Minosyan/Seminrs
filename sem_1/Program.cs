
// int number = 9; //number = 9
// int result = number * number; // 81
// Console.Write (result);

// Console.Write ("Введите число: ");
// int input = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine (input + 1000);


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

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
//N = 4, 4 * (-1) = -4
if (N < 0)
{
    Console.WriteLine("Введено отрицательное число N");
    N = N * -1;
}

int negativeN = N * -1; // -4


while (negativeN <= N)
{
    Console.Write(negativeN + " ");
    negativeN++; // negativeN++ это (negativeN = negativen + 1)
}


