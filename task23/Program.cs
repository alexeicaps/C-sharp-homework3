// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

void Cube(int num1)
{
    int count = 1;
    while (count <= num1)
    {
        if (count == num1)
        {
            Console.Write(count*count);
        }
    }
    count++;
}



int n = Prompt("введите число: ");
Cube(n);