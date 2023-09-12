// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все четные числа в промежутке от 1 до N.

Console.WriteLine("Enter number");
int numN = int.Parse(Console.ReadLine()??"0");
int evNumN = 2;

while (evNumN<numN)
{
	Console.Write (evNumN+",");
   evNumN += 2;
}
  