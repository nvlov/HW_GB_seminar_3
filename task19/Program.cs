/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a five-digit number:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number >= 10000 && number <= 99999)
        {
            int originalNumber = number;
            int reversedNumber = 0;

            while (number > 0)
            {
                int digit = number % 10;
                reversedNumber = reversedNumber * 10 + digit;
                number /= 10;
            }

            if (originalNumber == reversedNumber)
            {
                Console.WriteLine("The number is a palindrome.");
            }
            else
            {
                Console.WriteLine("The number is not a palindrome.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a five-digit number.");
        }
    }
}
