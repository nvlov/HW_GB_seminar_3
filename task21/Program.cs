/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/


using System;

class Program
{
    static void Main()
    {
        Console.Clear();
		Console.WriteLine("введите поочередно координаты (x, y, z) точки A: ");
        double ax = double.Parse(Console.ReadLine());
        double ay = double.Parse(Console.ReadLine());
        double az = double.Parse(Console.ReadLine());

        Console.WriteLine("введите поочередно координаты (x, y, z) точки B: ");
        double bx = double.Parse(Console.ReadLine());
        double by = double.Parse(Console.ReadLine());
        double bz = double.Parse(Console.ReadLine());

        double distance = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));

        Console.WriteLine("расстояние между точками А и В: {0:F2}", distance);
    }
}

