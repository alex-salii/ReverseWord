using ReverseWord;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsStringNull()
        {
            string testData = null;
            string revers = Anagram.Revers(testData);

            Assert.IsNull(revers);
        }
    }
}