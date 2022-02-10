// 20 Задача
// Задать номер четверти, показать диапазоны для возможных координат


using static System.Console;


WriteLine(" Введите номер четверти :");
int X = Read();

if (X <= 0 || X > 4)
{
    WriteLine(" Ошибка"); return;
}
if (X == 1)
{
    WriteLine("Первая четверть x > 0, y > 0");
}
if (X == 2)
{
    WriteLine(" Вторая четверть x < 0, y > 0");
}
if (X == 3)
{
    WriteLine(" Третья четверть x < 0, y < 0");
}
else if (X == 4)
{
    WriteLine(" Четвертая четверть x > 0, y < 0");
}

