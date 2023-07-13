// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


int Prompt(string message)
{
    Console.Write(message + " ");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

double Distance(int a, int b, int c, int d, int e, int f)
{
    double dist = Math.Sqrt((a - d)*(a - d) + (b - e)*(b - e) + (c - f)*(c - f));
    return dist;
}

int x1 = Prompt("x1 - ");
int y1 = Prompt("y1 - ");
int z1 = Prompt("z1 - ");
int x2 = Prompt("x2 - ");
int y2 = Prompt("y2 - ");
int z2 = Prompt("z2 - ");

Console.WriteLine(Distance(x1, y1, z1, x2, y2, z2));