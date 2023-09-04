// Напишите программу, которая на вход принимает число
// и выдаёт его квадрат (число умноженное на само себя).
Console.WriteLine("Введите число");
// считываем данные с консоли
string? inputNum = Console.ReadLine(); //??"0";
// проверяем чтоб данные не были пустыми
if(inputNum!=null)
{
//     int num = int.Parse(inputNum);
// // находим квадрат числа
//     int res = num * num;
// // выводим данные в консоль
//     Console.WriteLine(res);

    Console.WriteLine("Квадрат числа:"+(int)Math.Pow(int.Parse(inputNum), 2));
}