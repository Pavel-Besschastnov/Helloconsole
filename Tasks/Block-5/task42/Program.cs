
using static System.Console;
int num = 0;
int count = 0;
do
{
    WriteLine("хотите ввести число? ( y или n )");
    char chis = char.Parse(ReadLine());

    if (chis != 'y') break;


    WriteLine("введите число :");
    num = int.Parse(ReadLine());
    if (num > 0) count++;
} while (num > 0);
WriteLine($"сумма введенных чисел, больше 0= {count}");