﻿//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    int max = a;
    Console.WriteLine($"число {a} > {b} и является максимальным, a число{b} является минимальным");

} 
else
{
    int max = b;
    Console.WriteLine($"число {b} > {a} и является максимальным a число{a} является минимальным");
}
    