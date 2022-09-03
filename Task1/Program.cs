// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


class Program
{
static void Main(string[] args)
{
    Console.WriteLine("Введите число А");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B");
    int numberB = Convert.ToInt32(Console.ReadLine());
    int result = 1;
    for (int i = 0; i < numberB; i++)
    {
        result *= numberA;
    }
   Console.WriteLine("Число а в степени В = ");
   Console.WriteLine(result);
}
}