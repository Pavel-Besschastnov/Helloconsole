using static System.Console;
int number = int.Parse(ReadLine());
int b = 7;
int c = 23;

WriteLine(Getancwer7(number, b));
WriteLine(Getancwer23(number, c));


string Getancwer7(int number, int b)
{
    if (number % b == 0) return $"Число {number} кратно {b}";
    return $"Число {number} не кратно {b}";
}


string Getancwer23(int number, int c)
{
    if (number % c == 0) return $"Число {number} кратно {c}";
    return $"Число {number} не кратно {c}";
}
