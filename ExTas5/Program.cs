int n;
n = Convert.ToInt32(System.Console.ReadLine());
int[] nums = new int[n];

int i = 0;
for (i = 0; i < nums.Length; i++)
{
    nums[i] = Convert.ToInt32(System.Console.ReadLine());
}
int maxx = nums[0];
int maxxIndex = 0;
int minn = nums[0];
int minnIndex = 0;
for (i = 1; i < nums.Length; i++)
{
    if (maxx < nums[i]) { maxx = nums[i]; maxxIndex = i; }
    if (minn > nums[i]) { minn = nums[i]; minnIndex = i; }
}

if (maxxIndex > minnIndex)
{
    for (i = minnIndex; i <= maxxIndex; i++)
    {
        System.Console.WriteLine(nums[i]);
    }
}

else
{
    for (i = maxxIndex; i <= minnIndex; i++)
    {
        System.Console.WriteLine(nums[i]);
    }
}