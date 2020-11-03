using NUnit.Framework;
using ArraysAndStrings;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;
using NSubstitute;

namespace UnitTests
{
    public class Tests
    {
        Chapter1 c1 = new Chapter1();
        #region[Chapter 1 Tests]
        [Test]
        public void DuplicateLetters()
        {
            Assert.IsFalse(c1.isUniqueString("hello"));
        }

        [Test]
        public void EmptyString()
        {
            Assert.IsFalse(c1.isUniqueString(""));
        }

        [Test]
        public void SingleLetter()
        {
            Assert.IsTrue(c1.isUniqueString("a"));
        }
        [Test]
        public void CapitalsAndLowercase()
        {
            Assert.IsTrue(c1.isUniqueString("Havehut"));
        }
        [Test]
        public void Numeric()
        {
            Assert.IsFalse(c1.isUniqueString("135621"));
        }

        // String Permutation Tests
        [Test]
        public void CorrectPermutation()
        {
            Assert.IsTrue(c1.isPermutation("CAB", "BCA"));
        }

        [Test]
        public void FalsePermutation()
        {
            Assert.IsFalse(c1.isPermutation("BTF", "CFA"));
        }
        [Test]
        public void DifferentLengthPermutation()
        {
            Assert.IsFalse(c1.isPermutation("FGHY", "YGFYYH"));
        }
        #endregion

        // URLify String Tests
        [Test]
        public void BaseURLify()
        {
            Assert.AreEqual(c1.URLifyString("Mr John Smith", 13), "Mr%20John%20Smith");
        }
        [Test]
        public void MultipleSpacesTogether()
        {
            Assert.AreEqual(c1.URLifyString("Mr John   Smith", 15), "Mr%20John%20%20%20Smith");
        }
        [Test]
        public void NoSpaces()
        {
            Assert.AreEqual(c1.URLifyString("MrJohnSmith", 11), "MrJohnSmith");
        }

        [Test]
        public void IsUnique2_WithAnyStringFalse_ShouldReturnFalse()
        {
            // arrange
            var FakeChapter1 = Substitute.For<IChapter1>();
            FakeChapter1.isUniqueString(Arg.Any<string>()).Returns(false);

            // act
            IsUniqueClient client = new IsUniqueClient(FakeChapter1);

            // assert
            Assert.AreEqual(client.isUnique2("hello"), 2);
        }
    }
}