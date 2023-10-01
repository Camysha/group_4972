// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

//вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    // string value = Console.ReadLine(); // считывание строки с консоли
    int result = Convert.ToInt32(Console.ReadLine()); // преобразование строки в целое число из считанного из строки
    
    return result;
}

int [] InputArray (int length)
{
    int [] array = new int [length];
    for (int i = 0; i<array.Length; i++)
    {
        array [i] = ReadData ($"Введите {i + 1} -й элемент");
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) 
    { 
        Console.WriteLine($"a [{i}] = {array[i]}"); 
    }
   
}

int ConutPositiveNumbers(int [] array)
{
    int count = 0;
    for (int i =0; i<array.Length; i++)
    {
        if (array[i] > 0)
        {
            count ++;
        }
    }
    return count;
}

int length = ReadData("Введите количество элементов >");
int[] array;
array = InputArray(length);
PrintArray(array);
Console.WriteLine($"Количество чисел больше 0 - {ConutPositiveNumbers(array)}");