
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int numb = ReadInt("Введите число N: ");

for (int i = 1; i <= numb; i++)
{ 
    Console.Write($"{i*i*i} ");
}
