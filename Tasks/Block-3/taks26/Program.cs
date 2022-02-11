// 26 Задача
// Возведите число А в натуральную степень B используя цикл

using static System.Console;

int A = new Random().Next(1,10);
int B = new Random().Next(1,10);
int temp = 1;
WriteLine( $"Число A = {A}");
WriteLine( $"Число B = {B}");
for(int i = 1; i< B+1; i++)
{
    temp= temp *A;

}
WriteLine( $" Число А в натуральной степени В = {temp}");
