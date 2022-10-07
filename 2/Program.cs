Console.Write("Введите 1 число:");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите 2 число:");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите 3 число:");
int c = int.Parse(Console.ReadLine());
 int max = 0;
if(a>b & a>c){
    max= a;
    Console.WriteLine(max);
}
else if(b>a & b>c){
    max = b;
    Console.WriteLine(max);
} else if (c>a&c>b){
    max = c;
    Console.WriteLine(max);
}
