
int numberA = Convert.ToInt32("34");
int numberB = Convert.ToInt32("232");
int numberC = Convert.ToInt32("13");
int max = 0;
if (numberA > numberB)
{
    max = numberA;
}
else if (numberB > numberC)
{
    max = numberB;
}
else
{
    max = numberC;
}
Console.Write("максимальноечисло чмсло равно :  ");
Console.Write(max);