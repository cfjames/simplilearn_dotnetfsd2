using NUnit.Framework;

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
    }
}