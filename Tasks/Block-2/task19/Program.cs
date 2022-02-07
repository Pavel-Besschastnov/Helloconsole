// Задача 19
// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

using static System.Console;

int x = new Random().Next(-10, 10);
int y = new Random().Next(-10, 10);
WriteLine(x);
WriteLine(y);
if (x == 0 || y == 0)
{
    WriteLine(" Ошибка"); return;
}
if (x > 0 && y > 0)
{
    WriteLine("Первая четверть");
}
if (x < 0 && y > 0)
{
    WriteLine(" Вторая четверть");
}
if (x < 0 && y < 0)
{
    WriteLine(" Третья четверть");
}
else if(x > 0 && y < 0) 
{
    WriteLine(" Четвертая четверть");
}

