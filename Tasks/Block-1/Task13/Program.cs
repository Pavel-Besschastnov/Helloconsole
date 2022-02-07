using static System.Console;
WriteLine("Введите числа джля сравнения:  ");
int A = Convert.ToInt32(ReadLine());
int B = Convert.ToInt32(ReadLine());
if ((A % B) == 0 )
{
    WriteLine( "Число A Кратно B");
}
else
{
    WriteLine($" Остаток от деления : {A % B}");
}
