class Program
{
    static void Main(string[] args)
    {
        int numberOfTestCases = int.Parse(Console.ReadLine() ?? "0");

        Console.WriteLine("Number of cases:" + numberOfTestCases);
        for (int testCaseIndex = 0; testCaseIndex < numberOfTestCases; testCaseIndex++)
        {
            Console.WriteLine($"Case #{testCaseIndex}:");
            int numberOfCities = int.Parse(Console.ReadLine() ?? "0");
            for (int cityIndex = 0; cityIndex < numberOfCities; cityIndex++)
            {
                Console.WriteLine($"City #{cityIndex}:");
                string cityName = Console.ReadLine() ?? "";
            }
        }
    }
}
