﻿// Задача 8: Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);

int count = 2;

while(count <= num)
{
  Console.Write("{0} ", count);
  count = count +2;
}



