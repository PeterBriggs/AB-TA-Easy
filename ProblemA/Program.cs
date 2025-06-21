class Program
{
    static void Main(string[] args)
    {
        int numberOfTestCases = int.Parse(Console.ReadLine() ?? "0");
        List<int> results = new List<int>();

        for (int testCaseIndex = 0; testCaseIndex < numberOfTestCases; testCaseIndex++)
        {
            int numberOfCities = int.Parse(Console.ReadLine() ?? "0");
            int uniqueCitiesCount = ProcessCitiesAndGetUniqueCount(numberOfCities);
            results.Add(uniqueCitiesCount);
        }

        // Output all results after processing all inputs
        foreach (int count in results)
        {
            Console.WriteLine(count);
        }
    }

    static int ProcessCitiesAndGetUniqueCount(int numberOfCities)
    {
        HashSet<string> cities = new HashSet<string>();

        for (int cityIndex = 0; cityIndex < numberOfCities; cityIndex++)
        {
            string city = Console.ReadLine() ?? "";
            cities.Add(city);
        }

        return cities.Count;
    }
}
