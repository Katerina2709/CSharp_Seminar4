// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void PrintArray (int[] array) // вывод элементов массива на экран
{
    Console.Write ("[");
    foreach (var item in array)
    {
        Console.Write ($"{item}, ");
    }
     Console.Write ("\b\b]");
}

Console.Write ("Введите длину массива: ");
int leng = Convert.ToInt32(Console.ReadLine());
if (leng > 0 )
{
   int[] array = new int[leng];
   for (int i = 0; i < leng; i++)
   { 
        Console.Write ($"Введите {i} элемент массива: ");
        array [i] = Convert.ToInt32(Console.ReadLine());
   }
   PrintArray (array); // вывод на экран. 
}
else
{
    Console.Write ("Длина массива должна быть > 0");
}
     

