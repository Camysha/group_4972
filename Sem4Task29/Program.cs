// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


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

// Заполняем массив случайными числами
int[] GenArr(int len)
{
    int[] arr = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i] = rnd.Next(0, 100);
    }
    return arr;
}

int num = 8;
int[] res = GenArr(num);
PrintArray(res);
