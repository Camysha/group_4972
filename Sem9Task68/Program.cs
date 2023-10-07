﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

// метод ввода чисел
int ReadData(string line)
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int numM=ReadData($"Введите число M");
int numN=ReadData($"Введите число N");

// проверка и вывод результата
if(numM >= 0 && numN >= 0) Console.WriteLine(Ackermann(numM, numN));
else Console.WriteLine("Вы ввели неверные числа ");

// метод вычисления функции Аккермана
int Ackermann(int n, int m)
{
    if(n == 0) return m + 1;
    else if(m == 0) return Ackermann(n-1, 1);
    else return Ackermann(n - 1, Ackermann(n, m - 1));
}