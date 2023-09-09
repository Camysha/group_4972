// написать программу, которая принимает на вход число и выдает количество цифр в числе

// вводим число от пользователя ReadData
// вычисляем количество цифр NumDigit
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

int NumDigits(int num)
{
    int count = 0;
    while (num>0)
    {
        count ++;
        num=num/10;
    }
    return count;
}

int numberA = ReadData("Введите число: ");

int res = NumDigits(numberA);


PrintResult("В числе " +numberA+ " " +res+ " цифр");
