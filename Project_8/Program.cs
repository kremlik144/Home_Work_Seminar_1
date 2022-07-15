//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int result = 2;

if (x > 1)
{
    while(result <= x)
    {
       Console.Write(result);
       Console.Write(" ");
       result = result + 2; 
    } 
}
else
{
    Console.Write("Четных чисел нет");
}