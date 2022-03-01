// Задача 62
// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
int min= 100;
int pozx =0;
int pozy=0;
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10, 100);
        Console.Write($" {array[i, j]}");
        if(array[i,j]<min) 
        {
            min = array[i,j];
            pozx=i;
            pozy=j;
        }

    }
}
Console.WriteLine();
Console.WriteLine( $"Минимальный элемент в массиве = {min}");
Console.WriteLine("Массив после удаления столбца и строки, на пересечении которых находится мин элемент:");
int[,] massiv= new int[m,n];
for (int i = 0; i < massiv.GetLength(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j < massiv.GetLength(1); j++)
    {
        if(i!=pozx && j!=pozy)
        {
            massiv[i,j]= array[i,j];
            Console.Write($" {massiv[i, j]}");
        }
        

    }
}
Console.WriteLine();