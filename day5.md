Вопрос 1
Что выведет программа?
int number = 2;

switch (number)
{
    case 1:
        Console.WriteLine("A");
        break;

    case 2:
        Console.WriteLine("B");
        break;

    case 3:
        Console.WriteLine("C");
        break;
}

Ответ: "B"

Вопрос 2
Что выведет программа?
int number = 5;

switch (number)
{
    case 1:
        Console.WriteLine("One");
        break;

    case 2:
        Console.WriteLine("Two");
        break;

    default:
        Console.WriteLine("Other");
        break;
}

Ответ: Other

Вопрос 3
Будет ли компилироваться этот код? Почему?
int number = 1;

switch (number)
{
    case 1:
        Console.WriteLine("One");

    case 2:
        Console.WriteLine("Two");
        break;
}

Ответ: Нет, в первом case отсутствует break

Вопрос 4
Что выведет программа?
int day = 7;

switch (day)
{
    case 6:
    case 7:
        Console.WriteLine("Weekend");
        break;

    default:
        Console.WriteLine("Weekday");
        break;
}

Ответ: Weekend

Вопрос 5
В чём принципиальная разница между этими двумя конструкциями?
if (score >= 50)
{
    Console.WriteLine("Pass");
}

И:
switch (score)
{
    case 50:
        Console.WriteLine("Pass");
        break;
}

Ответ: В первом случае произойдёт вывод при всех значения больше 50 включительно, а во втором случае только при значении 50

Объясни своими словами, не просто перечисляй синтаксические отличия.