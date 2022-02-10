// Задача 18
// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

using static System.Console;
bool X = true;
bool Y= true;
bool z =(X && Y)! == X! || Y!;
WriteLine(z);
