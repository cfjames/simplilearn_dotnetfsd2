using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;


namespace Phase4Section1.UnitTests
{
    internal class TestCalculator
    {
        private ICalculator calculator;

        [SetUp]
        public void Setup()
        {
            //Arrange
            calculator = new Calculator();
        }

        [Test]
        public void Add_2_Integers_Returns_Valid_Integer()
        {
            ////Arrange
            //ICalculator calculator = new Calculator();

            //Act
            int answer = calculator.Add(5, 19);
            //Assert
            Assert.AreEqual(24, answer);
        }

        [Test]
        public void Add_2_NonIntegerStrings_Throws_InvalidOperationException()
        {
            //Assert
            Assert.Throws<InvalidOperationException>(()=> 
                //Act
                calculator.Add("Bob", "cat")
            );
        }

        [Test]
        [TestCase(5, 19, ExpectedResult = 24)]
        [TestCase(10, 20, ExpectedResult = 30)]
        [TestCase(100, 200, ExpectedResult = 300)]
        [TestCase(1000, 2000, ExpectedResult = 3000)]
        public int Add_2_Integers_Returns_Valid_Integer_TestCases(int x, int y)
        {
            return calculator.Add(x, y);
        }

        [Test]
        [TestCase("5", "19", ExpectedResult = 24)]
        [TestCase("10", "20", ExpectedResult = 30)]
        [TestCase("100", "200", ExpectedResult = 300)]
        [TestCase("1000", "2000", ExpectedResult = 3000)]
        public int Add_2_Strings_As_Int_Returns_Valid_Integer_TestCases(string x, string y)
        {
            return calculator.Add(x, y);
        }

        [Test]
        [TestCase("cat", "20")]
        [TestCase("20", "cat")]
        [TestCase("Bob", "cat")]
        [TestCase("10.5","20")]
        [TestCase("20", "10.5")]
        public void Add_Various_Strings_Throws_InvalidOperationException_TestCases(string x, string y)
        {
            //Assert
            Assert.Throws<InvalidOperationException>(() =>
                //Act
                calculator.Add(x, y)
            );
        }

        [Test]
        [TestCaseSource("TestCasesAddWith2Ints")]
        public int Add_2_Integers_Returns_Valid_Integer_TestCaseFile(int x, int y)
        {
            return calculator.Add(x, y);
        }

        [Test]
        [TestCaseSource("TestCasesAddWith2InvalidStrings")]
        public void Add_Various_Strings_Throws_InvalidOperationException_TestCaseFile(string x, string y)
        {
            //Assert
            Assert.Throws<InvalidOperationException>(() =>
                //Act
                calculator.Add(x, y)
            );
        }

        [Test]
        public void Subtract_2_Integers_Returns_Valid_Integer()
        {
            //Act
            int answer = calculator.Subtract(10, 5);
            //Assert
            Assert.AreEqual(5, answer);
        }

        [Test]
        public void Subtract_2_Integers_1_Negative_Throws_ArgumentOutOfRangeException()
        {
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() =>
                //Act
                calculator.Subtract(10, -5)
            );
        }

        [Test]
        public void Add_2_Integers_withMockDB_Returns_Valid_Integer()
        {
            //Arrange
            IDBDAO dBDAO = new MockDBDAO();
            ICalculator calculatorWithMockDb = new Calculator(dBDAO);

            //Act
            int answer = calculatorWithMockDb.Add(5, 19);
            //Assert
            Assert.AreEqual(24, answer);
        }

        private static List<TestCaseData> TestCasesAddWith2Ints
        {
            get
            {
                List<TestCaseData> testCases = new List<TestCaseData>();
                using (var fs = File.OpenRead(@"D:\Temp\Simplilearn\intTestCases.txt"))
                {
                    using (var reader = new StreamReader(fs))
                    {
                        string line = string.Empty;
                        while (line != null)
                        { 
                            line = reader.ReadLine();
                            if (line != null)
                            { 
                                string[] parts = line.Split(',', StringSplitOptions.TrimEntries);
                                int x = int.Parse(parts[0]);
                                int y = int.Parse(parts[1]);
                                int answer = int.Parse(parts[2]);
                                TestCaseData testCaseData = new TestCaseData(x, y).
                                    Returns(answer);
                                testCases.Add(testCaseData);
                            }
                        }
                    }
                }

                return testCases;
            }
        }

        private static List<TestCaseData> TestCasesAddWith2InvalidStrings
        {
            get
            {
                List<TestCaseData> testCases = new List<TestCaseData>();
                using (var fs = File.OpenRead(@"D:\Temp\Simplilearn\invalidStringTestCases.txt"))
                {
                    using (var reader = new StreamReader(fs))
                    {
                        string line = string.Empty;
                        while (line != null)
                        {
                            line = reader.ReadLine();
                            if (line != null)
                            {
                                string[] parts = line.Split(',', StringSplitOptions.TrimEntries);
                                TestCaseData testCaseData = new TestCaseData(parts[0], parts[1]);
                                testCases.Add(testCaseData);
                            }
                        }
                    }
                }

                return testCases;
            }
        }
    }

    public class MockDBDAO : IDBDAO
    {
        public string GetData()
        {
            return "Data from Hardcoded List";
        }
    }
}
