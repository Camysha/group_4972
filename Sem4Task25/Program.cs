// написать программу, которая принимает на вход 2 числа (а,b) и возводит a в степень b
// вводим число от пользователя ReadData
// вычисляем степень ShowStepen
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

int ShowStepen(int i, int j)
{
    int Stepen = (int)Math.Pow(i, j);
   
    return Stepen;
}

int numberA = ReadData("Введите число А: ");
int numberB = ReadData("Введите число B: ");

int res = ShowStepen(numberA, numberB);


PrintResult("a в степень b равно " + res);

