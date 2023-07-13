// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message) // Пишем передаваемое сообщение - запрашиваем у пользователя число - на выходе выдаем это число
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int quarter = Prompt("type quarter: ");
GetQuarter(quarter);

void GetQuarter(int num1)
{
    if (num1 < 1 || num1 > 4)
        Console.Write("неверный формат данных");
    if (num1 == 1) 
        Console.Write("x > 0 && y > 0");
    if (num1 == 2) 
        Console.Write("x < 0 && y > 0");
    if (num1 == 3) 
        Console.Write("x < 0 && y < 0");
    if (num1 == 4) 
        Console.Write("x > 0 && y < 0");
}