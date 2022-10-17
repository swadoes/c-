int programm, result, eNumber;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("Введите № задачи:");
    Console.WriteLine("1. Цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
    Console.WriteLine("2. Принимает на вход число и выдаёт сумму цифр в числе.");
    Console.WriteLine("3. Задаёт массив из X элементов и выводит их на экран.");
    programm = Convert.ToInt32(Console.ReadLine());

    switch (programm)
    {
        case 1:
            // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

            int eNumberA, eNumberB;

            Console.WriteLine("Для формулы A^B");
            Console.Write("Введите число A: ");
            eNumberA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число B: ");
            eNumberB = Convert.ToInt32(Console.ReadLine());

            result = eNumberA;

            for (int i = 2; i <= eNumberB; i++)
            {
                result *= eNumberA;
            }

            Console.WriteLine($"{eNumberA}^{eNumberB} = {result}");
            break;

        case 2:
            //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

            Console.Write("Введите любое число: ");
            eNumber = Convert.ToInt32(Console.ReadLine());
            result = 0;
            while (eNumber != 0)
            {
                result += eNumber % 10;
                eNumber /= 10;
            }

            Console.WriteLine($"Сумма цифр = {result}");

            break;

        case 3:
            //Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
            Console.WriteLine("Будет создан массив длиной A в диапвзоне 0-A");
            Console.Write("Введите любое число (A): ");
            eNumber = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[eNumber];

            for (int i = 0; i < eNumber; i++)
            {
                array[i] = new Random().Next(eNumber+1);
                Console.Write(array[i] + "; ");
            }
            Console.WriteLine();
            break;
    
       
        default:
            begin = false;
            break;
    }
}