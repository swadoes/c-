Console.Write("Введи число: ");
int anyNum = Convert.ToInt32(Console.ReadLine());
string input = Convert.ToString(anyNum);

if (input.Length > 1){
  Console.WriteLine( input+" -> " + input[1]);
} else{
     Console.WriteLine("-> второй цифры нет");
}
