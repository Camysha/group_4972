// Напишите программу, которая по заданному номеру четверти, показывает
// диапазон возможных координат точек в этой четверти (x и y).


//вводим данные
int ReadData(int num)
{
    Console.WriteLine(num);
    int numQuarter1 = int.Parse(Console.ReadLine()??"0");
    return numQuarter1;
}
// по координатам точки оперделяем номер четверти
string QuarterBorderAsk(int numQuarter)
{
    if (numQuarter == 1) return "x>0, y>0";
    if (numQuarter == 2) return "x<0, y>0";
    if (numQuarter == 3) return "x<0, y<0";
    if (numQuarter == 4) return "x>0, y<0";

    return String.Empty;
}

//печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

string x = ReadData("Введите номер четверти:");

int res = QuarterBorderAsk(x);

PrintResult("Точка находится в четверти № "+res);

