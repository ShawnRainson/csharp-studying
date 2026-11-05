//Задание 1. Чётные и нечётные числа
using System.ComponentModel;

Console.Write("Введите число: ");
string getString = Console.ReadLine()!;
int convertString = int.Parse(getString);

if(convertString % 2 == 0)
{
    Console.WriteLine("Чётное");
} else
{
    Console.WriteLine("Нечётное");
}

//Задание 2. Калькулятор
Console.Write("Введите первое число: ");
string firstString = Console.ReadLine()!;
Console.Write("Введите второе число: ");
string secondString = Console.ReadLine()!;
Console.Write("Введите операцию: ");
string operation = Console.ReadLine()!;
int firstNum = int.Parse(firstString);
int secondNum = int.Parse(secondString);

switch (operation)
{
    case "+":
            Console.WriteLine($"{firstNum} + {secondNum} = {firstNum + secondNum}");
            break;
    case "-":
            Console.WriteLine($"{firstNum} - {secondNum} = {firstNum - secondNum}");
            break;
    case "*":
            Console.WriteLine($"{firstNum} * {secondNum} = {firstNum * secondNum}");
            break;
    case "/":
            if (secondNum != 0)
        {
            Console.WriteLine($"{firstNum} + {secondNum} = {firstNum + secondNum}");
        } else
        {
            Console.WriteLine("Error: Cannot divide on zero!");
        };
        break;
    
    default:
           Console.WriteLine("Unknown operation.");
           break;
};

//Задание 3. Сумма чисел от 1 до N
Console.Write("Введите число N: ");
string getN = Console.ReadLine()!;
int n = int.Parse(getN);
int sum = 0;

for(int i = 1; i <= n; i++)
{
    sum += i;
}
Console.WriteLine($"Result: {sum}");

//Задание 4. Таблица умножения
Console.Write("Введите число: ");
string getNumber = Console.ReadLine()!;
int convertNumber = int.Parse(getNumber);

for(int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{convertNumber} * {i} = {convertNumber * i}");
}

//Задание 5. Проверка пароля
string password = "";

do
{
    Console.Write("Введите пароль: ");
    password = Console.ReadLine()!;
} while (password != "admin123");
Console.WriteLine("Вход разрешён.");

//Задание 6. Поиск чисел
for(int i = 1; i <= 100; i++)
{
    if(i > 80)
    {
        break;
    } else if (i % 2 != 0)
    {
        continue;
    } else if (i % 7 == 0)
    {
        Console.WriteLine(i);
    }
}

//Задание 7. Мини-программа «Угадай число»
int guessNum = 0;
int tries = 0;
int secretNum = 42;

while (guessNum != secretNum)
{
    Console.Write("Угадайте число: ");
    string guessStr = Console.ReadLine()!;
    guessNum = int.Parse(guessStr);

    if (guessNum > secretNum)
    {
        Console.WriteLine("Секретное число меньше.");
        tries++;
    } else if (guessNum < secretNum)
    {
        Console.WriteLine("Секретное число больше.");
        tries++;
    } else if (guessNum == secretNum)
    {
        Console.WriteLine("Поздравляем, вы выиграли!");
        tries++;
    }
}
Console.WriteLine($"Кол-во попыток: {tries}");