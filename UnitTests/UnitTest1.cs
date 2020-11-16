using NUnit.Framework;
using ArraysAndStrings;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;
using NSubstitute;
using System.Net.Http.Headers;

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

        /* Specific example for learning Dependency Injection
         * Through using NSubstitute, we are able to inject a mock "Fake"
         * isUnique2's dependency which is isUniqueString
         * This allows our test to remain a true Unit Test
         * having complete control over our testing 
        */
        [Test]
        public void IsUnique2_WithAnyStringFalse_ShouldReturnFalse()
        {
            // arrange
            //var FakeChapter1 = Substitute.For<IChapter1>();
            //FakeChapter1.isUniqueString(Arg.Any<string>()).Returns(false);

            IChapter1 chap1 = new Chapter1(); // Injecting Real Dependency

            // act
            //IsUniqueClient client = new IsUniqueClient(FakeChapter1); // Injecting a 'Fake' Dependency
            IsUniqueClient client = new IsUniqueClient(chap1);

            // assert
            Assert.AreEqual(client.isUnique2("hello"), 2);
        }

        // One Away String Tests
        [Test]
        public void OneAway_WithOneLetterOffAndDifferentLength_ShouldReturnTrue()
        {
            Assert.IsTrue(c1.OneAway("pale", "ple"));
        }
        [Test]
        public void OneAway_WithDuplicateLetters_ShouldReturnTrue()
        {
            Assert.IsTrue(c1.OneAway("Cool", "Fool"));
        }
        [Test]
        public void OneAway_WithTwoLettersOff_ShouldReturnFalse()
        {
            Assert.IsFalse(c1.OneAway("pale", "bake"));
        }
        [Test]
        public void OneAway_WithOneLetterOffSameLength_ShouldReturnTrue()
        {
            Assert.IsTrue(c1.OneAway("pale", "bale"));
        }
        [Test]
        public void OneAway_WithTwoLettersOffButSameLengthAsFirst_ShouldReturnFalse()
        {
            Assert.IsFalse(c1.OneAway("pale", "plee"));
        }
        [Test]
        public void OneAway_WithRemovingOneLetter_ShouldReturnTrue()
        {
            Assert.IsTrue(c1.OneAway("pales", "pale"));
        }
        [Test]
        public void OneAway_WithTwoLettersOffButDifferentLengthAsFirst_ShouldReturnFalse()
        {
            Assert.IsFalse(c1.OneAway("pales", "plee"));
        }

        // String Compression
        [Test]
        public void StringCompression_WithOneLetter_ShouldReturnEqual()
        {
            Assert.AreEqual("a3", c1.StringCompression("aaa"));
        }
        [Test]
        public void StringCompression_WithMultipleLetters_ShouldReturnEqual()
        {
            Assert.AreEqual("a2b1c5a3", c1.StringCompression("aabcccccaaa"));
        }
        [Test]
        public void StringCompression_WithCompressedBeingSameLength_ShouldReturnEqual()
        {
            Assert.AreEqual("aabbcc", c1.StringCompression("aabbcc"));
        }
        [Test]
        public void StringCompression_WithUncompressedBeingOneLonger_ShouldReturnEqual()
        {
            Assert.AreEqual("a2b2c3", c1.StringCompression("aabbccc"));
        }
    }
}