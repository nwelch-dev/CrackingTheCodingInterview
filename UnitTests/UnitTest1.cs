using NUnit.Framework;
using ArraysAndStrings;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;

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

        // String Permutation Tests
        [Test]
        public void CorrectPermutation()
        {
            Assert.IsTrue(Chapter1.isPermutation("CAB", "BCA"));
        }

        [Test]
        public void FalsePermutation()
        {
            Assert.IsFalse(Chapter1.isPermutation("BTF", "CFA"));
        }
        [Test]
        public void DifferentLengthPermutation()
        {
            Assert.IsFalse(Chapter1.isPermutation("FGHY", "YGFYYH"));
        }
        #endregion

        // URLify String Tests
        [Test]
        public void BaseURLify()
        {
            Assert.AreEqual(Chapter1.URLifyString("Mr John Smith", 13), "Mr%20John%20Smith");
        }
        [Test]
        public void MultipleSpacesTogether()
        {
            Assert.AreEqual(Chapter1.URLifyString("Mr John   Smith", 15), "Mr%20John%20%20%20Smith");
        }
        [Test]
        public void NoSpaces()
        {
            Assert.AreEqual(Chapter1.URLifyString("MrJohnSmith", 11), "MrJohnSmith");
        }
    }
}