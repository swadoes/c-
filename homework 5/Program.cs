// Теперь буду собирать всё в один файл.
int programm, result, eNumber;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("Введите № задачи:");
    Console.WriteLine("1. Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
    Console.WriteLine("2. Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
    Console.WriteLine("3.Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
    Console.WriteLine("4.Выход");
    programm = Convert.ToInt32(Console.ReadLine());

    switch (programm)
    {
        case 1:
            // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
                Console.WriteLine("Введите размер массива");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] numbers = new int[size];
                FillArrayRandomNumbers(numbers);
                Console.WriteLine("Вот наш массив: ");
                PrintArray(numbers);
                int count = 0;

                for (int z = 0; z < numbers.Length; z++)
                if (numbers[z] % 2 == 0)
                count++;

                Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");

                void FillArrayRandomNumbers(int[] numbers)
                {
                    for(int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = new Random().Next(100,1000);
                    }
                }
                void PrintArray(int[] numbers)
                {
                    Console.Write("[ ");
                    for(int i = 0; i < numbers.Length; i++)
                    {
                        Console.Write(numbers[i] + " ");
                    }
                    Console.Write("]");
                    Console.WriteLine();
                }
            break;

        case 2:
            //Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
                     Console.WriteLine("Введите размер массива");
                    int sizes = Convert.ToInt32(Console.ReadLine());
                    int[] numberss = new int[sizes];
                    FillArrayRandomNumbers(numberss);
                    Console.WriteLine("Вот наш массив: ");
                    PrintArray(numberss);
                    int sum = 0;

                    for (int z = 0; z < numberss.Length; z+=2)
                        sum = sum + numberss[z];

                        Console.WriteLine($"всего {numberss.Length} чисел, сумма элементов на нечётных позициях = {sum}");
            break;

        case 3:
            //Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
                Console.WriteLine("Введите размер массива");
                int sizee = Convert.ToInt32(Console.ReadLine());
                int[] numbeers = new int[sizee];
                FillArrayRandomNumbers(numbeers);
                Console.WriteLine("Вот наш массив: ");
                PrintArray(numbeers);
                double min = Int32.MaxValue;
                double max = Int32.MinValue;

                for (int z = 0; z < numbeers.Length; z++)
                {
                    if (numbeers[z] > max)
                        {
                            max = numbeers[z];
                        }
                    if (numbeers[z] < min)
                        {
                            min = numbeers[z];
                        }
                }

                Console.WriteLine($"всего {numbeers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
                Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
            break;
            case 4:
            System.Environment.Exit(1);
            break;
       
        default:
            begin = false;
            break;
    }
}