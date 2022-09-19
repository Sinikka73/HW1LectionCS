/*
Задача: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
*/

Console.Write("Введите значение целого числа А: ");
int userNumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение целого числа В: ");
int userNumberB = Convert.ToInt32(Console.ReadLine());

if(userNumberA == userNumberB)

    Console.Write("Числа равны: А = В");

else  if(userNumberA > userNumberB)
        
         Console.Write($"Большее число А: {userNumberA}. Меньшее число В:  {userNumberB}");
        
else Console.Write($"Большее число B: {userNumberB}. Меньшее число A:  {userNumberA}");
    