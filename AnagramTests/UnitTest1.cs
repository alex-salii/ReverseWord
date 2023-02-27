using ReverseWord;

namespace AnagramTests
{
    [TestFixture]
    public class Tests
    {
        //TestReversWord

        [Test]
        public void TestReversWord_�heckIsStringNull()
        {
            string testData = null;
            string revers = Anagram.ReverseWord(testData);

            Assert.IsNull(revers);
        }

        [Test]
        public void TestReversWord_�heckIsStringEmpty()
        {
            string testData = "";

            string actualData = Anagram.ReverseWord(testData);
            Assert.IsEmpty(actualData);
        }

        [Test]
        public void TestReversWord_�heckReversOneCorrectWord()
        {
            string testData = "Test";
            string expectedData = "tseT";

            string actualData = Anagram.ReverseWord(testData);
            Assert.AreEqual(expectedData, actualData);
        }

        [Test]
        public void TestReversWord_�heckReversNonAlphabeticSymbol()
        {
            string testData = "!\"#$%&'()*+,-./:; <=>?@[\\]^_`{|}~1234567890";
            string expectedData = "!\"#$%&'()*+,-./:; <=>?@[\\]^_`{|}~1234567890";

            string actualData = Anagram.ReverseWord(testData);
            Assert.AreEqual(expectedData, actualData);
        }

        [Test]
        public void TestReversWord_�heckReversWordAndSymbol()
        {
            string testData = "a1bcd  efg!h";
            string expectedData = "h1gfe  dcb!a";

            string actualData = Anagram.ReverseWord(testData);
            Assert.AreEqual(expectedData, actualData);
        }

        //TestRevers

        [Test]
        public void TestRevers_�heckIsStringNull()
        {
            string testData = null;
            string revers = Anagram.Revers(testData);

            Assert.IsNull(revers);
        }

        [Test]
        public void TestRevers_�heckIsStringEmpty()
        {
            string testData = "";

            string actualData = Anagram.Revers(testData);
            Assert.IsEmpty(actualData);
        }

        [Test]
        public void TestRevers_�heckReversNonAlphabeticSymbol()
        {
            string testData = "!\"#$%&'() *+,-./:; <=>? @[\\]^_`{|}~12 34567 890";
            string expectedData = "!\"#$%&'() *+,-./:; <=>? @[\\]^_`{|}~12 34567 890";

            string actualData = Anagram.Revers(testData);
            Assert.AreEqual(expectedData, actualData);
        }

        [Test]
        public void TestRevers_�heckReversWordAndSymbol()
        {
            string testData = "a1bcd  efg!h ed@1ui";
            string expectedData = "d1cba  hgf!e iu@1de";

            string actualData = Anagram.Revers(testData);
            Assert.AreEqual(expectedData, actualData);
        }

    }
}