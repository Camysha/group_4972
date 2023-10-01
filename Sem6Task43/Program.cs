// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

double ReadData(string msg)
{
    Console.WriteLine(msg);
    double result = Convert.ToDouble(Console.ReadLine()); 
    // преобразование строки в целое число из считанного из строки
    return result;
}

double K1 = ReadData("Input number K1: ");
double B1 = ReadData("Input number B1: ");
double K2 = ReadData("Input number K2: ");
double B2 = ReadData("Input number B2: ");

// Поиск координат пересечения
(double x, double y) pointA = CrossPoint(K1, B1, K2, B2);

// Метод вывода данных.
void PrintData(string msg)
{
    Console.WriteLine(msg);
}

// комплексный метод
(double x, double y) CrossPoint(double k1, double b1, double k2, double b2)
{
   
    double coorX1 = (b2 - b1) / (k1 - k2);
    double coorY1 = (k2 * ((b2 - b1) / (k1 - k2))+b2);
    return (coorX1, coorY1);
}

bool ValidateLines(double K1, double K2, double B1, double B2)
{
    if (K1 == K2) 
    {
        if (B1 == B2)
        {
            Console.WriteLine("Прямые совпадают");
            return false;
        }
        
        else 
        {
            Console.WriteLine("Прямые парралельны");
            return false;
        }
    }
    return true;
}

double X1 = pointA.x;
double Y1 = pointA.y;


if (ValidateLines(K1, K2, B1, B2))
{
    PrintData($"Cross points of 2 lines: X1= {X1}; Y1= {Y1}");
}
