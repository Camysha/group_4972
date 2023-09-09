// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
//и выдаёт номер четверти плоскости, в которой находится эта точка.


//вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine()??"0");
    return num;
}
// по координатам точки оперделяем номер четверти
int QterTest(int x, int y)
{
    if (x>0&&y>0) return 1;
    if (x<0&&y>0) return 2;
    if (x<0&&y<0) return 3;
    if (x>0&&y<0) return 4;

    return 0;
}

//печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int x = ReadData("Введите координату Х:");
int y = ReadData("Введите координату Y:");

int res = QterTest(x,y);

PrintResult("Точка находится в четверти № "+res);

