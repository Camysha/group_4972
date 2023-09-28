// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

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

// Проверяет количество четных числе в массиве
int CheckEvenNum(int[] array)
{
    int num = 0;
    for (int i = 0; i < array.Length; i++)
        
            if (array[i] % 2 == 0) num++;
            return num;

}

//печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int[] array = GenArray(5,99,999);
PrintArray(array);

int res = CheckEvenNum(array);

PrintResult("В массиве " +res+ " четных чисел");
