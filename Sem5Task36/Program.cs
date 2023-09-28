// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях

int[] GenArray(int num, int lowBorder, int highBorder)
{
    
    int[] array = new int[num];
    
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(lowBorder, highBorder+1);
    }

    return array;
}

// Печатаем результат
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
        
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Вычисляем сумму элементов, стоящих на нечётных позициях
int NegotivPositionSum(int[] arr)
{
    int Sum = 0;

    for(int i =1;i<arr.Length;i=i+2)

    Sum=Sum+arr[i];
    
    return Sum;
    
}

//печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int[] array = GenArray(5,1,10);
PrintArray(array);

int res = NegotivPositionSum(array);

PrintResult("Сумма элементов, стоящих на нечетных позициях равна " +res);

