using NUnit.Framework;

namespace Summator.Tests
{
    public class SummatorTests
    {
        [Test]
        public void Test_Sum_TwoPossitiveNumbers()
        {
           long result = SumatorProject.Summator.Sum(new long[] { 1, 2, 3, 7 });
            Assert.AreEqual(13, result);

        }
        [Test]
        public void Test_Sum_OnePossitiveNumber()
        {
            long result = SumatorProject.Summator.Sum(new long[] { 1, 2, 3, });
            Assert.That(0 < result & result < 10);

        }
        [Test]
        public void Test_Sum_TwoNegativeNumber()
        {
            long result = SumatorProject.Summator.Sum(new long[] {-5,-5 });
            Assert.That(result == -10);

        }
        [Test]
        public void Test_Sum_EmpetyArrey()
        {
            long result = SumatorProject.Summator.Sum(new long[] {  });
            Assert.That(result == 0);

        }

        [Test]
        public void Test_Sum_BigValue()
        {
            long result = SumatorProject.Summator.Sum(new long[] {2000000000, 2000000000, 2000000000 });
            
            Assert.AreEqual(result,6000000000);

        }
    }
}