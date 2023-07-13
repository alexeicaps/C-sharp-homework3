// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}


int number = Prompt("Введи пятизначное число: ");
GetPolindrom(number);

void GetPolindrom(int num)
{
    if (num > 99999 || num < 10000)
    {
        Console.WriteLine("Это не пятизначное число!!!");
    }
    else
    {
        if (GetFirstDigit(num) == GetLastDigit(num))
        {
            if (GetSecondDigit(num) == GetFourthDigit(num))
            {
            Console.WriteLine(num + " -> " + "да");
            }
            else
            {
                Console.WriteLine(num + " -> " + "нет");
            }
        }
        else
        {
            Console.WriteLine(num + " -> " + "нет");
        }
    }
}

int GetLastDigit(int numLast)
{
    return numLast % 10;
}

int GetFirstDigit(int num1)
{
    int a = num1 / 10000;
    return a;
}

int GetSecondDigit(int num2)
{
    int a = num2 % 10000;
    return a / 1000;
}

int GetFourthDigit(int num4)
{
    int b = num4 / 10;
    return b % 10;
}


