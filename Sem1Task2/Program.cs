// Задача №2
// Напишите программу, которая на вход принимает два числа 
// и выдает, какое число больше, а какое меньше
Console.WriteLine("Ведите первое число");
int numA = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Ведите второе число");
int numB = int.Parse(Console.ReadLine()?? "0");
if (numA > numB)
{
    Console.WriteLine("Максимальное число: {0}, Минимальное число: {1}", numA, numB);
}
else
{
   Console.WriteLine("Максимальное число: {1}, Минимальное число: {0}", numA, numB); 
}
