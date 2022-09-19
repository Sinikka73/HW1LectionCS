/*
Задача:   Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
*/

Console.Write("Введите значение целого числа: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if(userNumber % 2 == 0)

Console.Write($"Введённое число {userNumber} является чётным ");

else 
Console.Write($"Введённое число {userNumber} является нечётным ");