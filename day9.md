Вопрос 1. Что выведет код?
int a = 7;
int b = 2;

Console.WriteLine(a / b); - 3
Console.WriteLine(a % b); - 1


Вопрос 2. Что выведет код?
int age = 17;
bool hasPermission = true;

if (age >= 18 || hasPermission)
{
    Console.WriteLine("Доступ разрешён");
}
else
{
    Console.WriteLine("Доступ запрещён");
}
Ответ: Доступ запрещён

Вопрос 3. Что выведет код?
for (int i = 1; i <= 5; i++)
{
    if (i == 2 || i == 4)
    {
        continue;
    }

    Console.WriteLine(i);
}
Ответ: 1, 3, 5

Вопрос 4. Сколько раз выполнится Console.WriteLine?
int i = 1;

while (i < 4)
{
    for (int j = 1; j <= 3; j++)
    {
        Console.WriteLine($"{i}, {j}");
    }

    i++;
}
Ответ: 9 раз

Вопрос 5. Что выведет программа?
int number = 5;

do
{
    Console.WriteLine(number);
    number--;
}
while (number > 5); - 5


Вопрос 6. В чём разница между = и ==? - = - присваивание значения, == - проверка равенства

Вопрос 7. Какой тип данных лучше выбрать для хранения цены товара, если она может содержать копейки? - double