Console.Write("ВВедите число 1:");
int a = int.Parse(Console.ReadLine());

Console.Write("ВВедите число 2:");
int b = int.Parse(Console.ReadLine());

if(a>b){
    int max = a;
    Console.WriteLine(a);
} else{
     int max = b;
    Console.WriteLine(b);
}