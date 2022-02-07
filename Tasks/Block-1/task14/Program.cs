using static System.Console;
WriteLine("Введите число");
String number = ReadLine();
WriteLine();
if (number.Length < 3)
{
    WriteLine(" 3 числа не существует");
}
else
{
    WriteLine("3 числом по порядку является: ");
    WriteLine(number[2]);
}