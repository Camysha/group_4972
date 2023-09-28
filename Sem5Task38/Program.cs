// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] GenArray(int num, int lowBorder, int highBorder)
{
    
    double[] arr = new double[num];
    Random rnd = new Random();
    for (int i = 0; i < num; i++)
    {
        arr[i] = rnd.NextDouble() * (highBorder-lowBorder) + lowBorder;
    }

    return arr;
}


// Печатаем массив
void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
        
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}


double Max(double[] arr)
{
    int i = 0;
    double max = arr[i];
while (i < arr.Length)
{
    if(arr[i] > max) max = arr[i];
    i++;
}

return Math.Round(max, 2, MidpointRounding.ToZero);
}

double Min(double[] arr)
{
    int i = 0;
    double min = arr[i];
    while(i < arr.Length)
    {
        if(arr[i] < min) min = arr[i];
        i++;
    }
return Math.Round(min, 2, MidpointRounding.ToZero);
}



double Dif(double[] arr)
{
    double d = 0;
    double i = Max(arr);
    double t = Min(arr);
    d = i - t;
return d;
    
}


double[] array = GenArray(4,-100,100);
PrintArray(array);
Console.WriteLine();
Console.Write(Dif(array));