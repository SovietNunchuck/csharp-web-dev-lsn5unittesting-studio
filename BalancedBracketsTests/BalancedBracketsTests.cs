using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void EmptyStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        [TestMethod]
        public void OneBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[Launchcode"));
        }

        [TestMethod]
        public void MismatchedBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod]
        public void TwoLeftBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[text["));
        }

        [TestMethod]
        public void TwoRightBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]text]"));
        }

        [TestMethod]
        public void NestedBracketsReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[hello[x]world]"));
        }

        [TestMethod]
        public void MultipleBracketPairsReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[][][]"));
        }

        [TestMethod]
        public void AccidentalCurlyReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[woops}"));
        }

        [TestMethod]
        public void ParenthesesDontCountEither()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[(]]"));
        }

        [TestMethod]
        public void OpeningBracketsSpacedOutReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[Let's[give[this[a[shot]]]]]"));
        }

        [TestMethod]
        public void ClosingBracketsSpacedOutReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[[Goodbye]Cruel]World]"));
        }
    }
}