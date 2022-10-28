int programm, result, eNumber;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("Введите № задачи:");
    Console.WriteLine("1. Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
    Console.WriteLine("2. Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
    Console.WriteLine("3. Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
    Console.WriteLine("4.Выход");
    programm = Convert.ToInt32(Console.ReadLine());

    switch (programm)
    {
        case 1:
            // Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
            Console.WriteLine("введите количество строк");
            int linesVol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите количество столбцов");
            int columnsVol = Convert.ToInt32(Console.ReadLine());
            double[,] numbers = new double[linesVol, columnsVol];
            FillArrayRandomNumbers(numbers);
            PrintArray(numbers);
            break;

        case 2:
            //Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
            Console.WriteLine("введите номер строки");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите номер столбца");
            int m = Convert.ToInt32(Console.ReadLine());
            int [,] number = new int [10,10];
            FillArrayRandomNumber(number);

            if (n > number.GetLength(0) || m > number.GetLength(1))
            {
                Console.WriteLine("такого элемента нет");
            }
            else
            {
                Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {number[n-1,m-1]}");
            }

            
            break;
            case 3:
            //Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
            Console.WriteLine("введите количество строк");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите количество столбцов");
            int c = Convert.ToInt32(Console.ReadLine());

            int[,] numberss = new int[s, c];
            FillArrayRandomNumberss(numberss);


            for (int j = 0; j < numberss.GetLength(1); j++)
            {
                double avarage = 0;
                for (int i = 0; i < numberss.GetLength(0); i++)
                {
                    avarage = (avarage + numberss[i, j]);
                }
                avarage = avarage / s;
                Console.Write(avarage + "; ");
            }
            Console.WriteLine();
            PrintArrays(numberss);
            break;
            case 4:
            System.Environment.Exit(1);
            break;
       
        default:
            begin = false;
            break;
    }
    void FillArrayRandomNumbers(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
            }
        }
    }

    void PrintArray(double[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.Write("]");
            Console.WriteLine("");
        }
    }
    void FillArrayRandomNumber(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
            {        
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array [i,j] = new Random().Next(-100, 100)/10;
                }   
            }
    }
    void FillArrayRandomNumberss(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(0, 10);
            }
        }
    }
    void PrintArrays(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i,j] + " ");
            }   
            Console.Write("]");
            Console.WriteLine(""); 
        }
    }
}