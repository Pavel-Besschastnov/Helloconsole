// Задача 27
// Определить количество цифр в слове

using static System.Console;
WriteLine("введите слово с цифрами: ");
string ss = ReadLine();
int count = 0;
int a;
for (int i = 0; i < ss.Length; i++)
{
    bool result = int.TryParse((ss[i].ToString()),out a);
    if (result == true)
        count++;
}

WriteLine($"Количество цифр в слове : {count}");