//№15 Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//и проверяет, является ли этот день выходным.

System.Console.WriteLine("Input WeekDay"); //ввод числа для дня недели

int day = int.Parse(Console.ReadLine()??"0"); //проверка на неравенство 0

string[] dayOfWeek = new string[7]; //ввод массива

dayOfWeek[0] = "Понедельник";
dayOfWeek[1] = "Вторник";
dayOfWeek[2] = "Среда";
dayOfWeek[3] = "Четверг";
dayOfWeek[4] = "Пятница";
dayOfWeek[5] = "Суббота";
dayOfWeek[6] = "Воскресенье";

if(day<6) //условие для дня недели
{
Console.WriteLine("день недели " +dayOfWeek[day - 1]+ " это не выходной");
}
else
    {
        Console.WriteLine("день недели " +dayOfWeek[day - 1]+ " это выходной"); 
    }