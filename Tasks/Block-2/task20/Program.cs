// 20 Задача
// Задать номер четверти, показать диапазоны для возможных координат

using static System.Console;


WriteLine(" Введите номер четверти :");
int num = Convert.ToInt32(ReadLine());
if ( num <= 0 || num >4)
{
    WriteLine(" Ошибка");return;
}   
if (num  == 1)
{
    WriteLine("Первая четверть x > 0, y > 0");
}
if (num == 2)
{
    WriteLine(" Вторая четверть x < 0, y > 0");
    
}
if (num == 3)
{
    WriteLine(" Третья четверть x < 0, y < 0");
}
if (num == 4)
{
    WriteLine(" Четвертая четверть x > 0, y < 0");
}
