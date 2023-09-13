// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все четные числа в промежутке от 1 до N.

Console.Write("Введите число: "); // Создаем строку ввода
string? inputlineN = Console.ReadLine(); // Инициализируем сканер
int startNumber = 2; // Переменна, с кот начинается отчет

if (inputlineN != null) // Проверяем, что строка не пустая
{
int inputnumberN = int.Parse(inputlineN); // Парсим строку в инт
while (startNumber <= inputnumberN - 2) // Условие завершения цикла
{
Console.Write(startNumber + ", "); // Если число делится - выводим в консоль
startNumber = startNumber + 2; // прибавляем единицу к числу
}

if (startNumber % 2 == 0)
{
Console.WriteLine(startNumber);
}
}
  