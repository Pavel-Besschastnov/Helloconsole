// Задача 28
// Подсчитать сумму цифр в числе

using static System.Console;

String ss = ReadLine();
int sum = 0;
for (int i = 0; i < ss.Length; i++)
{
    sum = sum + int.Parse(ss[i].ToString());
}
WriteLine(sum);