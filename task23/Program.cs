/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

using System;

class Program
{
    static void Main()
    {
        Console.Clear();
		Console.Write("Enter a number (N): ");
        int n = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Number\tCube");

        for (int i = 1; i <= n; i++)
        {
            int cube = i * i * i;
            Console.WriteLine($"{i}\t{cube}");

        }
    }
}
