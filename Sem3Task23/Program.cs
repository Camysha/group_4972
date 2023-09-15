// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.1


using System;

public class Answer
{
   static void ShowCube(int N)
    {
      // Введите свое решение ниже
       int i = 1;
       int CubeRes = 0;
        while (i<= N)
        {
            CubeRes = (int)Math.Pow(i, 3);
            Console.WriteLine(CubeRes);
            i++;
        }
    }
   
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int N;

        if (args.Length >= 1) {
            N = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 5;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}