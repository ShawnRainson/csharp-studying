//Задание 1. Простые сравнения
Console.WriteLine(12 > 8); //true
Console.WriteLine(4 == 9); // false
Console.WriteLine(15 != 15); //false
Console.WriteLine(7 <= 7); //true
Console.WriteLine(20 < 10); //false

//Задание 2. Проверка возраста
int age = 20;

if (age >= 18)
{
    Console.WriteLine("Adult");
} else
{
    Console.WriteLine("Not adult");
};

age = 15; //Not adult

//Задание 3. Проверка температуры
int temperature = 25;

if (temperature > 30)
{
    Console.WriteLine("Hot");
} else if (temperature < 10)
{
    Console.WriteLine("Cold");
} else
{
    Console.WriteLine("Normal");
};

//Задание 4. Проверка баланса
int balance = 100;
int price = 75;
if (balance >= price)
{
    Console.WriteLine("Buy is alloweed");
} else
{
    Console.WriteLine("Balance is not enough");
};

//Задание 5. Оценка ученика
int score = 78;

if (score >= 90)
{
    Console.WriteLine("Excellent!");
} else if (score >= 70)
{
    Console.WriteLine("Good!");
} else if (score >= 50)
{
    Console.WriteLine("Okay");
} else
{
    Console.WriteLine("You need revise the material.");
};

//Задание 6. Самостоятельная задача — система доступа
int newAge = 17;
int requiredAge = 18;

if (newAge >= requiredAge)
{
    Console.WriteLine("Access");
} else
{
    Console.WriteLine("Block");
};