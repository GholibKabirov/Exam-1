int n;
n = Convert.ToInt32(System.Console.ReadLine());
int[] nums = new int[n];

int i = 0;
for (i = 0; i < nums.Length; i++)
{
    nums[i] = Convert.ToInt32(System.Console.ReadLine());
}
Array.Sort(nums);
int cnt = 1;
for (i = 1; i < nums.Length; i++)
{
    if (nums[i] != nums[i - 1]) { cnt++; }
}
System.Console.WriteLine(cnt);
