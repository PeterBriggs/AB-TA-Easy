class Program
{
    static void Main(string[] args)
    {
        try
        {
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) || !int.TryParse(input, out int numberOfTestCases) || numberOfTestCases <= 0) { Console.WriteLine("Invalid number of test cases. Please enter a positive integer."); return; }

            List<int> results = ProcessAllTestCases(numberOfTestCases);
            OutputResults(results);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }

    static List<int> ProcessAllTestCases(int numberOfTestCases)
    {
        List<int> results = new List<int>(numberOfTestCases);

        for (int testCaseIndex = 0; testCaseIndex < numberOfTestCases; testCaseIndex++)
        {
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) || !int.TryParse(input, out int numberOfTrips) || numberOfTrips < 0) { Console.WriteLine($"Invalid number of trips for test case {testCaseIndex + 1}. Using 0."); numberOfTrips = 0; }

            int uniqueCitiesCount = ProcessCitiesAndGetUniqueCount(numberOfTrips);
            results.Add(uniqueCitiesCount);
        }

        return results;
    }

    static int ProcessCitiesAndGetUniqueCount(int numberOfTrips)
    {
        HashSet<string> cities = new HashSet<string>();

        for (int tripIndex = 0; tripIndex < numberOfTrips; tripIndex++)
        {
            string? city = Console.ReadLine();
            if (!string.IsNullOrEmpty(city)) cities.Add(city); else Console.WriteLine($"Warning: Empty city name for trip {tripIndex + 1}. Skipping.");
        }

        return cities.Count;
    }

    static void OutputResults(List<int> results)
    {
        if (results.Count == 0) { Console.WriteLine("No results to display."); return; }

        foreach (int count in results)
        {
            Console.WriteLine(count);
        }
    }
}
