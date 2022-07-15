//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int x2 = Convert.ToInt32(Console.ReadLine());

if (x1 > x2)
{
   Console.Write("max = ");
   Console.WriteLine(x1); 
}
else
{
   Console.Write("max = ");
   Console.WriteLine(x2);  
}
