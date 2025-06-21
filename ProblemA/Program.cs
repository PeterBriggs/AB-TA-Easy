class Program
{
    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Number of cases:" + T);
        for (int t = 0; t < T; t++)
        {
            Console.WriteLine($"Case #{t}:");
        }
    }
}
