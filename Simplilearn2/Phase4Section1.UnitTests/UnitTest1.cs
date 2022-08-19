using System;
using NUnit.Framework;
using Moq;

namespace Phase4Section1.UnitTests
{
    public class Tests
    {
        private int grades1;
        private int grades2;
        private string name;

        [SetUp]
        public void Setup()
        {
            grades1 = 60;
            grades2 = 75;
            name = null;
        }

        [Test]
        public void BasicAssertions()
        {
            //int grades1 = 60;
            //int grades2 = 75;
            //string name = null;

            Assert.AreEqual(60, grades1);
            Assert.That(grades2, Is.EqualTo(75));
            Assert.AreNotEqual(grades2, grades1);
            Assert.That(grades2, Is.InRange(60, 75));

            Assert.IsNull(name);
        }

        [Test]
        public void Warnings()
        {
            //int grades1 = 60;
            //int grades2 = 75;
            //string name = null;

            Warn.If(grades1, Is.GreaterThan(100));
            Warn.If(name == null);

            Warn.Unless(grades1 + grades2, Is.GreaterThan(200));

            Assert.Warn("This is a warning message!");

            //Assert.Pass();
            //Assert.Fail();
        }

        [Test]
        public void MultipleAssertions()
        {
            Assert.Multiple(() =>
            {
                Assert.AreEqual(61, grades1);
                Assert.That(grades2, Is.EqualTo(74));
                Assert.AreNotEqual(grades2, grades1);
                Assert.That(grades2, Is.InRange(60, 75));

                Assert.IsNull(name);
            });
        }

        [Test]
        public void ShowStubTest()
        {
            //Arrange
            ICalculator calc = new StubCalculator();
            //Act
            int answer = calc.Add(5, 19);
            //Assert
            Assert.AreEqual(10, answer);
        }

        [Test]
        public void MockingTest()
        { 
            Mock<ICalculator> mock = new Mock<ICalculator>();
            ICalculator calc = mock.Object;
            Assert.That(calc, Is.Not.Null);
        }

        [Test]
        public void MockingAdvancedTest()
        {
            int x = 9;
            int y = 15;
            Mock<ICalculator> mock = new Mock<ICalculator>();
            mock.Setup(c => c.Add(It.IsAny<int>(), It.IsAny<int>())).Returns(x + y);

            //Arrange
            ICalculator calc = mock.Object;
            //Act
            int answer = calc.Add(x, y);
            //Assert
            Assert.AreEqual(answer, (x+y));
        }

        [Test]
        public void ShowDynamicMockTest()
        { 
            string x = "10";
            string y = "20";

            Mock<IDyanamicCalc> mock = new Mock<IDyanamicCalc>();
            var answer = new
            {
                V = Convert.ToInt32(x) + Convert.ToInt32(y)
            };

            mock.Setup(c => c.Add(It.IsAny<object>(), It.IsAny<int>())).
                Returns(answer);

            dynamic calc = mock.Object;
            dynamic validAns = calc.Add(x, y);
            Assert.AreEqual(answer, validAns);
        }

    }
}