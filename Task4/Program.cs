﻿// Доп.задача 
//Напишите программу, которая считывает с консоли числа (по одному в строке) до тех пор, пока сумма введённых чисел не будет 
//равна 0 и сразу после этого выводит сумму квадратов всех считанных чисел.
//Гарантируется, что в какой-то момент сумма введённых чисел окажется равной 0, после этого считывание продолжать не нужно.
//В примере мы считываем числа 1, -3, 5, -6, -10, 13; в этот момент замечаем, что сумма этих чисел равна нулю и выводим сумму их 
//квадратов, не обращая внимания на то, что остались ещё не прочитанные значения.
try
{
Console.WriteLine("Enter you number");
int x = Convert.ToInt32(Console.ReadLine());
int sum = (0 + x);
int sum2 = (0 + (x*x));
while (sum != 0)
{
    Console.WriteLine("Enter you number");
    int n = Convert.ToInt32(Console.ReadLine());
    sum  = sum + n;
    sum2 = (sum2 + (n*n));
    
}
Console.WriteLine(sum);
Console.Write(sum2);
}
catch
{
    Console.WriteLine("Please enter just integer numbers");
}
