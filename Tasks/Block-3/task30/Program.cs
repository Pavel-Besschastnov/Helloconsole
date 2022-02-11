// Задача 30
// Показать кубы чисел, заканчивающихся на четную цифру


using static System.Console;

int[] nums = new int[] { 213, 213, 4,32,17,70,2,34,41 };
int a = 0;
for(int i=0; i<nums.Length;i++)
{
    if ( nums[i]%2 ==0)
    {
        a = nums[i]*nums[i]*nums[i];
    WriteLine($"Куб четнjuj числа {nums[i]} :{a}");
    }


}