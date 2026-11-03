//Задание 1. Прерывание цикла
for(int i = 1; i <= 20; i++)
{
    if (i == 8)
    {
        break;
    };

    Console.WriteLine(i);
};

//Задание 2. Пропуск чисел
for(int i = 1; i <= 20; i++)
{
    if(i % 3 == 0)
    {
        continue;
    };
    Console.WriteLine(i);
};

//Задание 3. Чётные числа
int n = 1;

while (n <= 20)
{
    n++;

    if(n % 2 != 0)
    {
        continue;
    };

    Console.WriteLine(n);
};

//Задание 4. Поиск числа
for(int i = 1; i <= 100; i++)
{
    if(i % 7 == 0 && i % 9 == 0)
    {
        Console.WriteLine(i);
        break;
    };
}

//Задание 5. Прямоугольник из звёздочек

for(int i = 1; i <= 4; i++)
{
    for(int j = 1; j <= 6; j++)
    {
        Console.Write("*");
        if(j == 6)
        {
            Console.WriteLine(" ");
        };
    };
}


//Задание 6. Таблица умножения
for(int i = 1; i <= 5; i++)
{
    for(int j = 1; j <= 5; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    };
}

//Задание 7. Усложнённое — поиск подходящих чисел
for(int i = 1; i <= 100; i++)
{
    if(i > 90)
    {
        break;
    } else if (i % 3 != 0)
    {
        continue;
    } else if (i % 5 == 0)
    {
        Console.WriteLine(i);
    };
}