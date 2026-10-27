//Задание 1. День недели

int day = 6;

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    
    case 2:
         Console.WriteLine("Tuesday");
         break;
    
    case 3:
         Console.WriteLine("Wednesday");
         break;
    
    case 4:
         Console.WriteLine("Thursday");
         break;
    
    case 5:
         Console.WriteLine("Friday");
         break;
    
    case 6:
         Console.WriteLine("Saturday");
         break;
    
    case 7:
         Console.WriteLine("Sunday");
         break;
    
    default:
         Console.WriteLine("Unknown day");
         break;
};

//Задание 2. Простой калькулятор
double firstNumber = 10;
double secondNumber = 5;
char operation = '+';

switch (operation)
{
    case '+':
           Console.WriteLine(firstNumber + secondNumber);
           break;
    
    case '-':
           Console.WriteLine(firstNumber - secondNumber);
           break;
    
    case '*':
           Console.WriteLine(firstNumber * secondNumber);
           break;
    
    case '/':
           if (secondNumber != 0)
        {
            Console.WriteLine(firstNumber / secondNumber);
        } else
        {
            Console.WriteLine("Error: Second number cannot be zero!");
        };
        break;
    
    default:
           Console.WriteLine("Unknown operation");
           break;
};

//Задание 3. Выбор напитка
int choice = 2;

switch (choice)
{
    case 1:
          Console.WriteLine("Water");
          break;
    
    case 2:
          Console.WriteLine("Tea");
          break;
    
    case 3:
          Console.WriteLine("Coffee");
          break;
    
    case 4:
          Console.WriteLine("Juice");
          break;
    
    default:
          Console.WriteLine("Unknown option");
          break;
};

//Задание 4. Выходные и будни
switch (day)
{
    case 6:
    case 7:
          Console.WriteLine("Weekend");
          break;
    
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
          Console.WriteLine("Work day");
          break;
    
    default:
          Console.WriteLine("Invalid day");
          break;
};

//Задание 5. Мини-меню приложения

string command = "settings";
command = "start";

switch (command)
{
    case "profile":
                  Console.WriteLine("Opening profile...");
                  break;
    
    case "settings":
                  Console.WriteLine("Opening settings...");
                  break;
    
    case "help":
                  Console.WriteLine("Opening help...");
                  break;
    
    case "exit":
                  Console.WriteLine("Exit");
                  break;
    
    default:
                  Console.WriteLine("Invalid command");
                  break;
};

//Задание 6. Задача повышенной сложности — статус заказа
int status = 2;

switch (status)
{
    case 0:
          Console.WriteLine("Order created");
          break;
    
    case 1:
          Console.WriteLine("Payment received");
          break;
    
    case 2:
          Console.WriteLine("Order prepared");
          break;
    
    case 3:
          Console.WriteLine("Shipped");
          break;
    
    case 4:
          Console.WriteLine("Delivered");
          break;
    
    default:
          Console.WriteLine("Invalid status");
          break;
};
//Мне кажется что в реальной разработке, лучше использовать явное обозначение статуса в виде строки или char, чтобы не запутаться в значениях