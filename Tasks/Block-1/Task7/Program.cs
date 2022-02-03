int numbA = Convert.ToInt32(Console.ReadLine()); // Отрицательное число
int numbB = Convert.ToInt32(Console.ReadLine()); // Положительное число
int start = numbA;
while (start < numbB + 1)
{
    Console.Write( start);
    start++;
}