//Задание 1. Проверка чисел
Console.WriteLine(12 > 5 && 12 < 20);
Console.WriteLine(7 > 10 || 7 == 7);
Console.WriteLine(15 != 15);
Console.WriteLine(!(8 >= 1) && !(8 <= 10));
Console.WriteLine(0 != 0);

//Задание 2. Доступ в клуб
int age = 20;
bool hasTicket = false;

if (age >= 18 && hasTicket)
{
    Console.WriteLine("Welcome!");
} else
{
    Console.WriteLine("Go away.");
};

//Задание 3. Скидка
bool hasDiscountCard = false;
bool isBirthday = true;

if (hasDiscountCard || isBirthday)
{
    Console.WriteLine("Discount is 50%");
} else
{
    Console.WriteLine("Standard price");
};

//Задание 4. Проверка диапазона
int score = 66;

if (score >= 0 && score <= 100)
{
    Console.WriteLine("Valid score.");
} else
{
    Console.WriteLine("Invalid score");
};

//Задание 5. Чуть сложнее
bool isBlocked = false;

if (age >= 18 && hasTicket && !isBlocked)
{
    Console.WriteLine("Welcome!");
} else if (age >= 18 && !hasTicket && !isBlocked)
{
    Console.WriteLine("You have to buy the ticket.");
} else if (age < 18 || isBlocked)
{
    Console.WriteLine("Go away.");
};