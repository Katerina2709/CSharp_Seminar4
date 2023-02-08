// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumNumb (int numb)
{
   int sum = 0;
   while (numb > 0)
   {
        sum = sum + numb % 10;
        numb = numb / 10;
   }
   return sum;
}

Console.Write ("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ( $"Сумма цифр в числе {number} -> {SumNumb (Math.Abs (number))}" ); 
// число может быть отрицательным, поэтому берем его модуль