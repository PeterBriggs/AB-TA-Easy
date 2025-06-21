class Program
{
    static void Main(string[] args)
    {
        int numberOfTestCases = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Number of cases:" + numberOfTestCases);
        for (int testCaseIndex = 0; testCaseIndex < numberOfTestCases; testCaseIndex++)
        {
            Console.WriteLine($"Case #{testCaseIndex}:");
        }
    }
}
