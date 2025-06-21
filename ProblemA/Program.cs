class Program
{
    static void Main(string[] args)
    {
        int numberOfTestCases = int.Parse(Console.ReadLine() ?? "0");
        List<int> results = ProcessAllTestCases(numberOfTestCases);

        OutputResults(results);
    }

    static List<int> ProcessAllTestCases(int numberOfTestCases)
    {
        List<int> results = new List<int>(numberOfTestCases);

        for (int testCaseIndex = 0; testCaseIndex < numberOfTestCases; testCaseIndex++)
        {
            int numberOfTrips = int.Parse(Console.ReadLine() ?? "0");
            int uniqueCitiesCount = ProcessCitiesAndGetUniqueCount(numberOfTrips);

            results.Add(uniqueCitiesCount);
        }

        return results;
    }

    static int ProcessCitiesAndGetUniqueCount(int numberOfCities)
    {
        HashSet<string> cities = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        for (int cityIndex = 0; cityIndex < numberOfCities; cityIndex++)
        {
            string city = Console.ReadLine() ?? "";

            cities.Add(city);
        }

        return cities.Count;
    }

    static void OutputResults(List<int> results) =>
        results.ForEach(result => Console.WriteLine(result));
}
