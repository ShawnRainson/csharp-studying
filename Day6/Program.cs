//Задача 1. Простой счётчик
for(int i = 1; i <= 20; i++)
{
    Console.WriteLine(i);
}

//Задача 2. Обратный отсчёт
for(int i = 10; i >= 1; i--)
{
    Console.WriteLine(i);
};
Console.WriteLine("Поехали!");

//Задача 3. Чётные числа
for(int i = 2; i <= 30; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    };
}

//Задача 4. Сумма чисел
int sum = 0;
for(int i = 1; i <= 100; i++)
{
    sum += i;
};
Console.WriteLine(sum);

//Задача 5. Таблица умножения

for(int i = 1; i <= 10; i++)
{
    int result = 7;
    result *= i;
    Console.WriteLine($"7 * {i} = {result}");
};

//Задача 6. Подсчёт подходящих чисел
int counter = 0;
for(int i = 1; i <= 50; i++)
{
    if (i % 7 == 0)
    {
        counter++;
    };
}
Console.WriteLine($"Count: {counter}");

//Задача 7. Сумма только чётных чисел
int oddSum = 0;
for(int i = 1; i <= 20; i++)
{
    if(i % 2 == 0)
    {
        oddSum += i;
    };
}
Console.WriteLine(oddSum);