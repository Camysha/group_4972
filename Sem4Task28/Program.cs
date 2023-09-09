// написать программу, которая принимает на вход число N и выдает произведение чисел от 1 до N

// вводим число от пользователя ReadData
// вычисляем произведение Factorial
// выводим результат PrintResult

//вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}

//печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// вычисление произведения

long Factorial(int num)
{
    long result = 1;
    for (int i = 2; i<=num; i++)
    {
        result = result * i;
    }
    return result;
}


int numberA = ReadData("Введите число А: ");

long res = Factorial(numberA);


PrintResult("Факториал числа " +numberA + " равен "+ res);