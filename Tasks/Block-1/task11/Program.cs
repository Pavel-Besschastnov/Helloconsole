int numb = new Random().Next(10, 99);
Console.WriteLine(numb);
int numbA = numb / 10;
int numbB = numb % 10;
if (numbA > numbB)
{
    Console.WriteLine($"Наибольшая цифра числа :  {numbA}");
}
else if (numbB > numbA)
{
    Console.WriteLine($"Наибольшая цифра числа : {numbB}");
}
else
{
    Console.WriteLine("Числа равны.");
}