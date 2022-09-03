//Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

using System;

class Program
{
    static void Main(String[]args)
    {
        string number = console.ReadLine();
        string [] array = new string[number.Length];
        int index = 0;
        foreach (var item in number) /// 1, 24, 613, 124
        {
            if(item !=",")
            {
                array[index]+= item.ToString();
            }
            else
            {
            index++;
            }
        }
        Console.Write("["); //[
            for(int i = 0; i <= index-1; i++)
            {
                console.Write(array[i]+ ","); //[1. 24. 15]
            }
            Console.Write(array[index] + "]"); // [1, 24, 15]
    }
}
