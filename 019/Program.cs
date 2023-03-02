Console.Write("your number = ");
int N = Convert.ToInt32(Console.ReadLine());

if (N % 10 == N / 10000)
{
    if (((N % 100) - (N / 10000)) / 10 == (N / 1000) - ((N % 10) * 10))
    {
        Console.WriteLine("yes ^_^");
    }
}
else
{
    Console.WriteLine("no...");
}


/*Console.Write("your number = ");
int N = Convert.ToInt32(Console.ReadLine());

int result = (N / 1000) - ((N % 10) * 10);
Console.WriteLine(result);*/