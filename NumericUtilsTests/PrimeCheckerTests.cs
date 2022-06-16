using NumericUtils;

namespace NumericUtilsTests
{
    public class PrimeCheckerTests
    {
        PrimeChecker checker;

        [SetUp]
        public void Setup()
        {
            checker = new PrimeChecker();
        }

        [TearDown]
        public void TearDown()
        {
        }

        [Test]
        public void ZeroIsPrimeTest()
        {
            Assert.IsFalse(checker.IsPrime(0));
        }

        [Test]
        public void OneIsPrimeTest()
        {
            Assert.IsFalse(checker.IsPrime(1));
        }

        [Test]
        public void TwoIsPrimeTest()
        {
            Assert.IsTrue(checker.IsPrime(2));
        }

        [Test]
        public void FourIsPrimeTest()
        {
            Assert.IsFalse(checker.IsPrime(4));
        }
    }
}