using NUnit.Framework;

namespace Summator.Tests
{
    internal class AverageTests
    {
        [Test]
        public void Test_Average_PossitiveNumber()
        {
            int result = SumatorProject.Summator.Average(new int[] { 1, 2, 3 });
            Assert.AreEqual(2, result);

        }

       

    }
}
                                                                                