using static System.Console;
WriteLine(" введите день недели: ");
int number = int.Parse(ReadLine());
WriteLine(Dayoff(number));



string Dayoff(int a)
{
    int[] nums = new int[] { 6, 7, 13, 14, 20, 21, 27, 28 };
    for (int j= 0; j < nums.Length; j++) 
    {
        
        if(nums[j] == number)
        {
            WriteLine($"введеный день ({number}) недели является выходным");
            break;
            
        }
        else if (j==nums.Length -1)
        {
            WriteLine("Этот день недели не выходной");
        }
        
     
    }

    return $"";
}
