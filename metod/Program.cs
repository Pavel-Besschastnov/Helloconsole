void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

int[] array = new int[10];

void PrintArray(int[] col)
{
    int count = col.Length;
    int posicion = 0;
    while (posicion < count)
    {
        Console.WriteLine(col[posicion]);
        posicion++;
    }
}

int Indexoff(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int posicion=0;
    while (index < count)
    {
        if (collection[index] == find)
        {
            posicion = index;
        }
        index++;
    }
    return posicion;
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = Indexoff(array,5);
Console.WriteLine(pos);