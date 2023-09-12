// Задача №4
// Напишите программу, которая на вход принимает три числа 
// и выдает максимальное из этих чисел

Console.WriteLine("Ведите первое число");
int numA = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Ведите второе число");
int numB = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine("Ведите третье число");
int numC = int.Parse(Console.ReadLine()?? "0");
int max = numA;
if (numA > max) max = numA;
if (numB > max) max = numB;
if (numC > max) max = numC;
Console.WriteLine("Максимальное число: {0}", max); 
