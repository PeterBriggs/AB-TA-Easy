using System;
using System.Collections.Generic;

/*
 * Solution for counting the number of unique cities Alice has visited.
 * This program takes input describing Alice's travel history and outputs
 * the count of distinct cities for each test case.
 */
public class Program
{
    /*
     * Entry point of the application. Reads the number of test cases,
     * processes each test case, and outputs the results.
     */
    public static void Main()
    {
        int numberOfTestCases = int.Parse(Console.ReadLine() ?? "0");
        List<int> results = ProcessAllTestCases(numberOfTestCases);

        OutputResults(results);
    }

    /*
     * Processes each test case by reading the number of trips and
     * calculating the number of unique cities visited.
     *
     * @param numberOfTestCases - The total number of test cases to process
     * @return A list containing the number of unique cities for each test case
     */
    public static List<int> ProcessAllTestCases(int numberOfTestCases)
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

    /*
     * Reads city names from input and calculates the number of unique cities.
     * Uses a HashSet to automatically track only distinct city names.
     *
     * @param numberOfCities - The number of trips/cities to process
     * @return The count of unique cities
     */
    public static int ProcessCitiesAndGetUniqueCount(int numberOfCities)
    {
        HashSet<string> cities = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        for (int cityIndex = 0; cityIndex < numberOfCities; cityIndex++)
        {
            string city = Console.ReadLine() ?? "";
            cities.Add(city);
        }

        return cities.Count;
    }

    /*
     * Outputs the results to the console, one per line.
     *
     * @param results - The list of unique city counts to output
     */
    public static void OutputResults(List<int> results) =>
        results.ForEach(result => Console.WriteLine(result));
}
