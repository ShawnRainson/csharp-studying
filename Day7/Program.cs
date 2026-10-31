//Задание 1. Числа от 1 до 10
int x = 1;

while (x <= 10)
{
    Console.WriteLine(x);
    x++;
}

//Задание 2. Обратный отсчёт
int i = 20;
while (i >= 1)
{
    Console.WriteLine(i);
    i--;
}
Console.WriteLine("Старт!");

//Задание 3. Сумма чисел
int sum = 0;
int s = 1;

while (s <= 100)
{
    sum += s;
    s++;
}

Console.WriteLine($"Сумма: {sum}");

//Задание 4. Числа от 1 до N
Console.Write("Введите число: ");
string n = Console.ReadLine()!;
int m = int.Parse(n);
int num = 1;

while (num <= m)
{
    Console.WriteLine(num);
    num++;
}//Насчёт этого задания я протестую, здесь необходимо реализовать ввод с клавиатуры, ты мне его ранее показывал, а вот изменения типа данных из строки в число нет, пришлось искать самому.

//Задание 5. Проверка пароля
string password = "";

do
{
    Console.Write("Введите пароль: ");
    password = Console.ReadLine()!;
} while (password != "qwerty");
Console.WriteLine("Пароль принят!");

//Задание 6. Ввод положительного числа
int number = 0;

do
{
    Console.Write("Введите положительное число: ");
    string input = Console.ReadLine()!;
    number = int.Parse(input);
} while (number <= 0);
Console.WriteLine("Спасибо! Вы ввели положительное число.");

//Задание 7. Сумма введённых чисел
int sum2 = 0;
int convertInput = 0;
do
{
    Console.Write("Введите число: ");
    string input = Console.ReadLine()!;
    convertInput = int.Parse(input);
    sum2 += convertInput;
} while (convertInput != 0);
Console.WriteLine($"Сумма: {sum2}");