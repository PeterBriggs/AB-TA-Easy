# Unique Cities Counter – C# Technical Assessment

This is a C# console application developed as part of a technical assessment for a Senior Developer position at Agile Bridge.

## 🧠 Problem Description

Given multiple test cases, each containing a number of city names (representing trips), the program determines how many **unique cities** were visited in each test case.

### 📥 Input Format

- The first line contains an integer `T`, the number of test cases.
- For each test case:
  - The first line contains an integer `N`, the number of trips.
  - The next `N` lines each contain a city name (no spaces in names).

### 📤 Output Format

- For each test case, output a single integer: the number of unique cities visited.

### ✅ Example

**Input:**
```
2
3
London
Paris
London
2
Berlin
Madrid
```

**Output:**
```
2
2
```

---

## 🛠 Technologies Used

- Language: **C# (.NET Core)**
- Input/Output: `Console.ReadLine()` / `Console.WriteLine()`
- Data structure: `HashSet<string>` for uniqueness

---

## 🚀 How to Run

### Using .NET CLI

1. Open a terminal and navigate to the project folder.
2. Build the program:
   ```bash
   dotnet build
   ```
3. Run the program:
   ```bash
   dotnet run --project ProblemA\ProblemA.csproj

You will be prompted to enter the test input manually (as described above).

---

## ✅ Running the Tests

To execute the included unit tests:

1. Ensure you are in the root directory of the project.
2. Run the following command:
   ```bash
   dotnet test
   ```

This will build and run all tests located in the `UnitTests.cs` file.

---

## 💡 Notes

- The program assumes valid input format.
- Duplicate city names within a test case are ignored.
- City names are case-insensitive (e.g., `Paris` = `paris`).
- No external libraries or frameworks are used.

---
