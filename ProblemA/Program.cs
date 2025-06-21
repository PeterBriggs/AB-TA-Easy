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
            int uniqueCitiesCount = ProcessCitiesAndGetUniqueCount(numberOfCities);

            Console.WriteLine("Unique cities:");
            Console.WriteLine(uniqueCitiesCount);
        }
    }

    static int ProcessCitiesAndGetUniqueCount(int numberOfCities)
    {
        HashSet<string> cities = new HashSet<string>();

        for (int cityIndex = 0; cityIndex < numberOfCities; cityIndex++)
        {
            Console.WriteLine($"City #{cityIndex}:");

            string city = Console.ReadLine() ?? "";
            cities.Add(city);
        }

        return cities.Count;
    }
}
