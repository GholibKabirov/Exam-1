double n;
n = Convert.ToInt32(System.Console.ReadLine());
double i;
double cnt = 0;
for (i = 0; i <= n; i++)
{
    cnt += Math.Pow(2, i);
}

System.Console.WriteLine(cnt);
