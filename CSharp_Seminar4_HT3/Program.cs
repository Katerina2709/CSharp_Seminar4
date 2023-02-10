// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] FillArray (int len, int dStart, int dEnd) // заполнение массива произвольными числами
{
    int[] arrayNumb = new int[len];
    for (int i = 0; i< len; i++)
    {
        arrayNumb[i] = new Random().Next(dStart, dEnd + 1);
    }
    return arrayNumb;
}

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
Console.Write ("Введите начало диапазона чисел в массиве: ");
int d1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("конец диапазона: ");
int d2 = Convert.ToInt32(Console.ReadLine());

PrintArray (FillArray (leng, d1, d2)); // задаёт массив из leng элементов и выводит их на экран.
