Console.Write("Введи день недели: \n");
int anyNum = Convert.ToInt32(Console.ReadLine());
string input = Convert.ToString(anyNum);

if (anyNum != 6 && anyNum != 7){
    Console.WriteLine("Рабочий день");
  
}else if (anyNum>7){
    Console.WriteLine("Это точно день недели?");
}

 else{
     Console.WriteLine("этот день является выходным");
}
