namespace EqualityCheck.Tests
{
    public class EqualityCheckerTest
    {
        [Theory]
        [InlineData(1, true, false)]
        [InlineData(0, "0", false)]
        [InlineData(1, 1, true)]
        public void TestEqualsCheckerSuccess(object value, object comparasionValue, bool resultExpected)
        {
            var result = value.EqualsChecker(comparasionValue);
            Assert.Equal(resultExpected, result);
        }
    }
}