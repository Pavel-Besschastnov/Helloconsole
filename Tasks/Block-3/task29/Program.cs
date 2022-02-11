// Задача 29
//Написать программу вычисления произведения чисел от 1 до N

using static System.Console;

int numberN = new Random().Next(1,20);
int pro= 1;
WriteLine(numberN );
for ( int i =1 ; i<numberN;i++)
{
    pro = pro * i;
    WriteLine($"{pro} * {i} = {pro}");
}