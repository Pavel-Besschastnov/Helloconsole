// Задача 41
//  Выяснить являются ли три числа сторонами треугольника
using static System.Console;

int a = int.Parse(ReadLine());
int b = int.Parse(ReadLine());
int c = int.Parse(ReadLine());

if (a * a + b * b == c * c) WriteLine("Введенные числа являются треугольником");
if (a * a + c * c == b * b) WriteLine("Введенные числа являются треугольником");
if (b * b + c * c == a * a) WriteLine("Введенные числа являются треугольником");
if((a * a + b * b != c * c) && (a * a + c * c != b * b) && (b * b + c * c != a * a))WriteLine(" Введенные числа не являются треугольником");
 