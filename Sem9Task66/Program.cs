﻿// Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
//Выполнить с помощью рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

// метод ввода чисел
int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int numM=ReadData($"Введите число M");
int numN=ReadData($"Введите число N");

// проверка и вывод суммы
if(numM <= 0 && numN <= 0) Console.WriteLine("Вы ввели неверные числа");
else
Console.WriteLine($"Сумма элементов между M и N равна {SumNumbers(numM, numN)}");

// метод вычисления суммы между M и N
int SumNumbers(int num1, int num2)
{
    if(num1 == num2) return num1;
    else if(num2 > num1) return num1 + SumNumbers(num2, num1 + 1);
    else return num2 + SumNumbers(num1, num2 + 1);
}



