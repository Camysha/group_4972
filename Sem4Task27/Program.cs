// №27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

// вводим число от пользователя ReadData
// вычисляем количество цифр SumDigits
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

// вычисление количества цифр

int SumDigits(int num)
{
    int sum = 0;
    while (num>0)
    {
        sum = sum+num%10;
        num = num/10;
    }
    return sum;
}

int numberA = ReadData("Введите число: ");

int res = SumDigits(numberA);


PrintResult("Сумма цифр числа " +numberA+ " равна " +res);
