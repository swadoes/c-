int programm, result, eNumber;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("Введите № задачи:");
    Console.WriteLine("1. Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.");
    Console.WriteLine("2. 66 Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.");
    Console.WriteLine("3.68 Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
    Console.WriteLine("4.Выход");
    programm = Convert.ToInt32(Console.ReadLine());

    switch (programm)
    {
        case 1:
            // Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
            Console.WriteLine("Введите натуральное число больше 1:");
            int number = int.Parse(Console.ReadLine());
            NumberCounter(number);
            break;

        case 2:
            //Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
            Console.WriteLine("Введите начальное число M:");
            int numberM = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите начальное число N:");
            int numberN = int.Parse(Console.ReadLine());
            GapNumberSum(numberM, numberN, 0);
            break;
            case 3:
            //Задача 68 Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
            Console.WriteLine("Введите начальное число M:");
            int numberMs = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите начальное число N:");
            int numberNs = int.Parse(Console.ReadLine());
            Console.WriteLine($"Функция Аккермана для чисел A({numberMs},{numberNs}) = {AckermannFunction(numberMs, numberNs)}");
            break;
            case 4:
            System.Environment.Exit(1);
            break;
       
        default:
            begin = false;
            break;
    }
        void NumberCounter (int number)
        {
            if (number % 2 == 0) Console.Write($"{number}"+ " ");
            if (number == 0) return;
            
            NumberCounter (number - 1);
        }
        void GapNumberSum (int numberM, int numberN, int sum)
        {
            if (numberM > numberN) 
            {
                Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
                return;
            }
            sum = sum + (numberM++);
            GapNumberSum(numberM, numberN, sum);
        }
        int AckermannFunction (int numberMs, int numberNs)
        {
            if (numberMs == 0) return numberNs + 1;
            if (numberMs != 0 && numberNs == 0) return AckermannFunction(numberMs - 1, 1);
            if (numberMs > 0 && numberNs > 0) return AckermannFunction(numberMs - 1, AckermannFunction(numberMs, numberNs - 1));
        return AckermannFunction(numberMs, numberNs);
        }
}