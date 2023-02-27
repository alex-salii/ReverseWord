using ReverseWord;

namespace AnagramTests
{
    [TestFixture]
    public class Tests
    {
        //TestReversWord

        [Test]
        public void TestReversWord_ÑheckIsStringNull()
        {
            string testData = null;
            string revers = Anagram.ReverseWord(testData);

            Assert.IsNull(revers);
        }

        [Test]
        public void TestReversWord_ÑheckIsStringEmpty()
        {
            string testData = "";

            string actualData = Anagram.ReverseWord(testData);
            Assert.IsEmpty(actualData);
        }

        [Test]
        public void TestReversWord_ÑheckReversOneCorrectWord()
        {
            string testData = "Test";
            string expectedData = "tseT";

            string actualData = Anagram.ReverseWord(testData);
            Assert.AreEqual(expectedData, actualData);
        }

        [Test]
        public void TestReversWord_ÑheckReversNonAlphabeticSymbol()
        {
            string testData = "!\"#$%&'()*+,-./:; <=>?@[\\]^_`{|}~1234567890";
            string expectedData = "!\"#$%&'()*+,-./:; <=>?@[\\]^_`{|}~1234567890";

            string actualData = Anagram.ReverseWord(testData);
            Assert.AreEqual(expectedData, actualData);
        }

        [Test]
        public void TestReversWord_ÑheckReversWordAndSymbol()
        {
            string testData = "a1bcd  efg!h";
            string expectedData = "h1gfe  dcb!a";

            string actualData = Anagram.ReverseWord(testData);
            Assert.AreEqual(expectedData, actualData);
        }

        //TestRevers

        [Test]
        public void TestRevers_ÑheckIsStringNull()
        {
            string testData = null;
            string revers = Anagram.Revers(testData);

            Assert.IsNull(revers);
        }

        [Test]
        public void TestRevers_ÑheckIsStringEmpty()
        {
            string testData = "";

            string actualData = Anagram.Revers(testData);
            Assert.IsEmpty(actualData);
        }

        [Test]
        public void TestRevers_ÑheckReversNonAlphabeticSymbol()
        {
            string testData = "!\"#$%&'() *+,-./:; <=>? @[\\]^_`{|}~12 34567 890";
            string expectedData = "!\"#$%&'() *+,-./:; <=>? @[\\]^_`{|}~12 34567 890";

            string actualData = Anagram.Revers(testData);
            Assert.AreEqual(expectedData, actualData);
        }

        [Test]
        public void TestRevers_ÑheckReversWordAndSymbol()
        {
            string testData = "a1bcd  efg!h ed@1ui";
            string expectedData = "d1cba  hgf!e iu@1de";

            string actualData = Anagram.Revers(testData);
            Assert.AreEqual(expectedData, actualData);
        }

    }
}