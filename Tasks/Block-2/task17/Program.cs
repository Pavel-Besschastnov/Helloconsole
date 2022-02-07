// Задача 17 По двум заданным числам проверять является ли одно квадратом другого
using static System.Console;

int numberA = new Random().Next(2,5);
int numberB = new Random().Next(2,3);

WriteLine($"{numberA},{numberB}");

if (numberA == numberB * numberB)
{
    WriteLine( " первое число является квадратом второго");
}
else if (numberB == numberA * numberA)
{
    WriteLine( "Второе число является квадратом первого числа");
}
else
{
    WriteLine(  " Ни одно число не является квадратом другого.");
}
