// Задача №1
// Напишите программу, которая на вход принимает два числа 
// и проверяет, является ли первое число квадратом второго.
Console.WriteLine("Ведите первое число");
int numA = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Ведите первое число");
int numB = int.Parse(Console.ReadLine()?? "0");
if (numA*numA == numB)
{
    Console.WriteLine("Второе число квадрат первого");
}
else
{
   Console.WriteLine("Второе число не квадрат первого"); 
}
