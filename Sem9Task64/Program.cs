// Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

// метод ввода чисел 
int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// метод, кот выдает натуральные числа от n до 1
void NaturalNumbers(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturalNumbers(num - 1);

}
int n=ReadData($"Ведите N, больше 0 ");
if(n > 0) NaturalNumbers(n);
else Console.WriteLine("Вы ввели неверное число");