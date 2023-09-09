// написать программу, которая принимает на вход число (а) и выдает сумму чисел от 1 до а

// вводим число от пользователя ReadData
// вычисляем сумму
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

// вычисление суммы

int SimpleSum(int numA)
{
    int SumOfNumber = 0;
    for (int i = 1; i<=numA; i++)
    {
        SumOfNumber = SumOfNumber + i;
        // SumOfNumber+=i;
    }
    return SumOfNumber;
}

int GaussSum(int numA)
{
    int SumOfNumber = 0;
    SumOfNumber=(numA*(numA+1))/2;
    return SumOfNumber;
}
int numberA = ReadData("Введите число А: ");

int res1 = SimpleSum(numberA);
int res2 = GaussSum(numberA);

PrintResult("Сумма чисел от 1 до " +numberA + " равна "+ res1);
PrintResult("Сумма чисел от 1 до " +numberA + " равна "+ res2);