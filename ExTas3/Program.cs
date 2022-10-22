int n;
n = Convert.ToInt32(System.Console.ReadLine());
int[] nums = new int[n];

int i = 0;
for (i = 0; i < nums.Length; i++)
{
    nums[i] = Convert.ToInt32(System.Console.ReadLine());
}
int b;
for (i = 1; i < nums.Length; i = i + 2)
{
    b = nums[i];
    nums[i] = nums[i - 1];
    nums[i - 1] = b;

}
for (i = 0; i < nums.Length; i++)
{
    System.Console.WriteLine(nums[i]);
}
