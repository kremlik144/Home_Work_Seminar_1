//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Введите первое число");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int x3 = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (x1 > max)
{
    max = x1;
}
if (x2 > max)
{
    max = x2;
}
if (x3 > max)
{
    max = x3;
}

Console.Write("Максимальное число = ");
Console.WriteLine(max);