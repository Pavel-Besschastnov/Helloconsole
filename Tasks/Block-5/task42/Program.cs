// Задача 42
// Определить сколько чисел больше 0 введено с клавиатуры
using static System.Console;

Console.WriteLine("Введите числа:");
string stroka= Console.ReadLine();
int count=1;
byte backnum=0;
foreach(char a in stroka)
{
int temp=Convert.ToByte(a);
if((byte)a==32 && (byte)a!=backnum) count++;
backnum=(byte)a;


}
Console.WriteLine($"количество введенных чисел = {count}");
