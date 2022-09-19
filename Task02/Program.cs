/*
Задача:  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
*/

Console.Write("Введите значение целого числа А: ");
int userNumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение целого числа В: ");
int userNumberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение целого числа C: ");
int userNumberC = Convert.ToInt32(Console.ReadLine());

int max = userNumberA;


if(userNumberA > max) max = userNumberA;
if(userNumberB > max) max = userNumberB;
if(userNumberC > max) max = userNumberC;
Console.Write($"Максимальное число {max} ");

