int numb = Convert.ToInt32(Console.ReadLine());
int start = 1;
while (start < numb +1)
{
   if (start % 2 == 0)
   {
       Console.WriteLine(start);
   } 
   start++;
}