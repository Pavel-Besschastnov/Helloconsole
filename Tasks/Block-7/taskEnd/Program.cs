int[] data = { 1, 0, 1, 1, 0, 1, 0, 1, 1, 1, 1, 0, 0, 1, 1, 0, 1, 1, 0, 1 };
Console.WriteLine("Массив Data :");
for (int i = 0; i < data.Length; i++)
{
Console.Write($" {data[i]}");
}
Console.WriteLine();
int[] datainfo = { 3, 4, 3, 2, 5, 3 };
Console.WriteLine("Массив Datainfo :");
for (int i = 0; i < datainfo.Length; i++)
{
Console.Write($" {datainfo[i]}");

}
Console.WriteLine();
string datamedia = string.Empty;

for (int i = 0; i < data.Length; i++)
{

datamedia = datamedia + data[i].ToString();

}
//Console.WriteLine(datamedia);
Console.WriteLine();
int startindex = 0;
string str = string.Empty;
int[] numb = new int[6];
for (int i = 0; i < datainfo.Length; i++)
{

str = datamedia.Substring(startindex, datainfo[i]);
startindex = startindex + datainfo[i];
numb[i] = Convert.ToInt32(str, 2);
}
Console.WriteLine("числа в десятичной системе :");
for (int i = 0; i < 6; i++)
{

Console.Write($" {numb[i]}");
}
Console.WriteLine();