using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemA.Tests
{
    [TestClass]
    [DoNotParallelize]
    public class UnitTests
    {
        [TestMethod]
        public void Main_WithSampleInput_ProducesSampleOutput()
        {
            // Arrange
            string input = "2\n" +
                        "7\n" +
                        "saskatoon\n" +
                        "toronto\n" +
                        "winnipeg\n" +
                        "toronto\n" +
                        "vancouver\n" +
                        "saskatoon\n" +
                        "toronto\n" +
                        "3\n" +
                        "edmonton\n" +
                        "edmonton\n" +
                        "edmonton\n";

            var reader = new StringReader(input);
            Console.SetIn(reader);

            var writer = new StringWriter();
            Console.SetOut(writer);

            // Act
            Program.Main();

            // Assert
            string expectedOutput = "4\n1\n";
            Assert.AreEqual(
                expectedOutput.Replace("\r", "").Trim(),
                writer.ToString().Replace("\r", "").Trim()
            );
        }

        [TestMethod]
        public void ProcessCitiesAndGetUniqueCount_WithDuplicateCities_ReturnsCorrectCount()
        {
            // Arrange
            string input = "saskatoon\n" +
                        "toronto\n" +
                        "winnipeg\n" +
                        "toronto\n" +
                        "vancouver\n" +
                        "saskatoon\n" +
                        "toronto\n";
            var reader = new StringReader(input);
            Console.SetIn(reader);

            // Act
            int result = Program.ProcessCitiesAndGetUniqueCount(7);

            // Assert
            Assert.AreEqual(4, result);
        }


        [TestMethod]
        public void ProcessCitiesAndGetUniqueCount_WithIdenticalCities_ReturnsOne()
        {
            // Arrange
            var originalIn = Console.In;
            string input = "edmonton\nedmonton\nedmonton\n";
            using (var reader = new StringReader(input))
            {
                Console.SetIn(reader);

                // Act
                int result = Program.ProcessCitiesAndGetUniqueCount(3);

                // Assert
                Assert.AreEqual(1, result);
            }
        }

        [TestMethod]
        public void ProcessCitiesAndGetUniqueCount_WithDifferentCasing_CountsAsSameCity()
        {
            // Arrange
            string input = "Toronto\ntoronto\nTORONTO\n";
            var reader = new StringReader(input);
            Console.SetIn(reader);

            // Act
            int result = Program.ProcessCitiesAndGetUniqueCount(3);

            // Assert
            Assert.AreEqual(1, result);  // Should be 1 when using StringComparer.OrdinalIgnoreCase
        }
    }
}
