using NUnit.Framework;
using ArraysAndStrings;

namespace UnitTests
{
    public class Tests
    {
        #region[Chapter 1 Tests]
        [Test]
        public void DuplicateLetters()
        {
            Assert.IsFalse(Chapter1.isUniqueString("hello"));
        }

        [Test]
        public void EmptyString()
        {
            Assert.IsFalse(Chapter1.isUniqueString(""));
        }

        [Test]
        public void SingleLetter()
        {
            Assert.IsTrue(Chapter1.isUniqueString("a"));
        }
        [Test]
        public void CapitalsAndLowercase()
        {
            Assert.IsTrue(Chapter1.isUniqueString("Havehut"));
        }
        [Test]
        public void Numeric()
        {
            Assert.IsFalse(Chapter1.isUniqueString("135621"));
        }
        #endregion
    }
}