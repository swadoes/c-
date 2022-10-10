Console.Write("Введи число: ");
int anyNum = Convert.ToInt32(Console.ReadLine());
string input = Convert.ToString(anyNum);

if (input.Length > 2){
  Console.WriteLine( input+" -> " + input[2]);
} else{
     Console.WriteLine("-> третьей цифры нет");
}
