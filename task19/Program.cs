// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

GetSquare();

void GetSquare()
{
        Console.Write("x1 - ");
        int x1 = int.Parse(Console.ReadLine());

        Console.Write("y1 - ");
        int y1 = int.Parse(Console.ReadLine());

        Console.Write("x2 - ");
        int x2 = int.Parse(Console.ReadLine());

        Console.Write("y2 - ");
        int y2 = int.Parse(Console.ReadLine());

        double a = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1));

        Console.WriteLine(Math.Round(a,2));
}