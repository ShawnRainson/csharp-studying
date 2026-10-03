//🔥 Задание 6 — пишем код
string name = "John";
int age = 26;
double height = 1.91;
bool isStudent = false;

Console.WriteLine($"Name: {name}\n");
Console.WriteLine($"Age: {age}\n");
Console.WriteLine($"Height: {height}\n");
Console.WriteLine($"Student status: {isStudent}\n");

//⭐ Задание 7 — изменение переменных

int newAge = 20;
newAge = 21;// Потому-что переменная уже создана и её не надо по новой объявлять
Console.WriteLine(newAge);
newAge += 1;// А это пример как можно иначе увеличить переменную
Console.WriteLine(newAge);