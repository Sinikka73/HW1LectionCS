/*
Задача:   Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
*/
Console.Write("Введите целое положительно значение N: ");
int userNumberN = Convert.ToInt32(Console.ReadLine());

int count = 2;

if(userNumberN > 1)


while (count <= userNumberN)
{
    Console.Write($"{count}, ");
    count = count + 2;
}
      
else Console.Write("К сожалению, с такими входными данными задача не имеет решения");