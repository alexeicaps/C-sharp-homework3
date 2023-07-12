// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int x = Prompt("Введите точку X: ");
int y = Prompt("Введите точку Y: ");
int z = Prompt("Введите точку Z: ");


if (x > 0 && y > 0 && z > 0)
{
    Console.WriteLine("I четверть");
}
if (x > 0 && y > 0)
{
    Console.WriteLine("II четверть");
}
if (x > 0 && y > 0)
{
    Console.WriteLine("III четверть");
}
if (x > 0 && y > 0)
{
    Console.WriteLine("IV четверть");
}