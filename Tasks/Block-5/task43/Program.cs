// 43 Задача
// Написать программу преобразования десятичного числа в двоичное

Console.WriteLine("перевод чисел из 10 систесы в 2,4,6,8");
Console.WriteLine("в какую систему хотите перевести");
int znak= int.Parse(Console.ReadLine());
Console.WriteLine($"выбрана {znak} система счисления");
Console.WriteLine("Введите число для перевода");
int decim= int.Parse(Console.ReadLine());
int[] temp= new int[20];
for(int i=0;i<temp.Length;i++)
{
int ost=decim%znak;
decim= decim/znak;
temp[i]=ost;
if(decim==znak)break;


}
Console.WriteLine($"число в {znak} системе =");
Array.Reverse(temp, 0, temp.Length);
int count=0;
for(int j=0;j<temp.Length;j++)
{
if(temp[j]>0) break;
else count++;

}
for (int j=count;j<temp.Length;j++)
{
Console.Write($" {temp[j]}");
}
Console.WriteLine();