// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int NumbPower (int numb, int stpn)
{
    int result = numb;
    for (int i = 1; i < stpn; i++ )
    {
        result *= numb;
    }        
    return result;    
}

Console.Write ("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine ());
Console.Write ("Введите степень числа (натуральное число): ");
int power = Convert.ToInt32 (Console.ReadLine ());

if (power < 1)
{
    Console.WriteLine ("Введено неверноеи значение степени");
}
else
{
    Console.WriteLine ( $"{number} ^ {power} = {NumbPower (number, power)}" );
} 

