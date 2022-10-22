int n;
n = Convert.ToInt32(System.Console.ReadLine());
int[] nums = new int[n];

int i = 0;
for (i = 0; i < nums.Length; i++)
{
    nums[i] = Convert.ToInt32(System.Console.ReadLine());
}

for (i = 0; i < nums.Length; i++)
{
    System.Console.WriteLine(nums[i]);
}
