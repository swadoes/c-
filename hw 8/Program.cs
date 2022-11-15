int programm, result, eNumber;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("Введите № задачи:");
    Console.WriteLine("1. Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
    Console.WriteLine("2. Задача 56: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
    Console.WriteLine("3. Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
    Console.WriteLine("4.Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");
    Console.WriteLine("5.Задача 62: Заполните спирально массив 4 на 4.");
    Console.WriteLine("6.Выход");
    programm = Convert.ToInt32(Console.ReadLine());

    switch (programm)
    {
        case 1:
            // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
            Console.WriteLine("введите количество строк");
            int linesVol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите количество столбцов");
            int columnsVol = Convert.ToInt32(Console.ReadLine());
            int[,] numbers = new int[linesVol, columnsVol];
            FillArrayRandomNumbers(numbers);
            Console.WriteLine();
            Console.WriteLine("Массив до изменения");
            PrintArray(numbers);

            for (int q = 0; q < numbers.GetLength(0); q++)
            {
                for (int w = 0; w < numbers.GetLength(1) - 1; w++)
                {
                    for (int z = 0; z < numbers.GetLength(1) - 1; z++)
                    {
                        if (numbers[q, z] < numbers[q, z + 1]) //для изменения сортировки поменять знак < на противоположный
                        {
                            int temp = 0;
                            temp = numbers[q, z];
                            numbers[q, z] = numbers[q, z + 1];
                            numbers[q, z + 1] = temp;
                        }
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Массив с упорядоченными значениями");
            PrintArray(numbers);




            break;

        case 2:
            //Задача 56: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
           Console.WriteLine("введите размер квадратного массива");
            int massVol = Convert.ToInt32(Console.ReadLine());
            int[,] number = new int[massVol, massVol];
            FillArrayRandomNumbers(number);
            PrintArray(number);
            int minsum = Int32.MaxValue;
            int indexLine = 0;

            for (int o = 0; o < number.GetLength(0); o++)
            {
                int sum = 0;
                for (int z = 0; z < number.GetLength(1); z++)
                {
                    sum = sum + number[o, z];        
                }
                if (sum < minsum)
                {
                    minsum = sum;
                    indexLine++;
                }
            }

            Console.WriteLine("строка с наименьшей суммой елементов под номером: " + (indexLine) + ", с суммой елементов равной: " + (minsum));

            
            break;
            case 3:
            //Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
            
            int size = InputInt("размерность матриц: ");
            int[,] matrixA = new int[size, size];
            int[,] matrixB = new int[size, size];
            FillArrayRandomNumberss(matrixA);
            FillArrayRandomNumberss(matrixB);
            int[,] matrixC = new int[size, size];

            for (int x = 0; x < size; x++)
            {
                for (int c = 0; c < size; c++)
                {
                    for (int k = 0; k < size; k++)
                    {
                        matrixC[x, c] = matrixC[x,c] + (matrixA[x, k] * matrixB[k, c]);
                    }
                }
            }
            Console.WriteLine("Матрица - А");
            PrintArray(matrixA);
            Console.WriteLine();
            Console.WriteLine("Матрица - В");
            PrintArray(matrixB);
            Console.WriteLine();
            Console.WriteLine("Произведение матриц А*В");
            PrintArray(matrixC);
            break;
            case 4:
            //Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
            int deep1 = InputInt("Введите размерность 1: ");
            int deep2 = InputInt("Введите размерность 2: ");
            int deep3 = InputInt("Введите размерность 3: ");
            int countNums = 89;

            if (deep1 * deep2 * deep3 > countNums)
            {
                Console.Write("Массив слишком большой");
                return;
            }

            int[,,] resultNums = Create3DMassive(deep1, deep2, deep3);

            for (int b = 0; b < resultNums.GetLength(0); b++)
            {
                for (int v = 0; v < resultNums.GetLength(1); v++)
                {
                    for (int k = 0; k < resultNums.GetLength(2); k++)
                    {
                        Console.WriteLine($"[{b},{v},{k}] - {resultNums[b, v, k]}");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }


            int[,,] Create3DMassive(int size1, int size2, int size3)
            {
                int[,,] array = new int[size1, size2, size3];
                int[] values = new int[countNums];
                int num
                = 10;
                for (int i = 0; i < values.Length; i++)
                    values[i] = num
                    ++;

                for (int i = 0; i < values.Length; i++)
                {
                    int randomInd = new Random().Next(0, values.Length);
                    int temp = values[i];
                    values[i] = values[randomInd];
                    values[randomInd] = temp;
                }

                int valueIndex = 0;

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        for (int k = 0; k < array.GetLength(2); k++)
                        {
                            array[i, j, k] = values[valueIndex++];
                        }
                    }
                }
                return array;
            }

            break;
            case 5:
            //Задача 62: Заполните спирально массив 4 на 4.
            Console.WriteLine("Введите размер массива");
            int sizes = Convert.ToInt32(Console.ReadLine());

            int[,] nums = new int[sizes, sizes];

            int num = 1;
            int i = 0;
            int j = 0;

            while (num <= sizes * sizes)
            {
                nums[i, j] = num;
                if (i <= j + 1 && i + j < sizes - 1)
                    ++j;
                else if (i < j && i + j >= sizes - 1)
                    ++i;
                else if (i >= j && i + j > sizes - 1)
                    --j;
                else
                    --i;
                ++num;
            }

            PrintArray(nums);
            break;
            case 6:
            System.Environment.Exit(1);
            break;
       
        default:
            begin = false;
            break;
    }
        void FillArrayRandomNumbers(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(0, 10);
            }
        }
    }
    void PrintArray(int[,] array)
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
    void FillArrayRandomNumberss(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(1, 5); //Для увеличения размера чисел сменить 5 на большее
            }
        }
    }
    int InputInt(string output)
            {
                Console.Write(output);
                return int.Parse(Console.ReadLine());
            }
}