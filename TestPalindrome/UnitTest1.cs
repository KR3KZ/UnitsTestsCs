using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeApp;
namespace TestPalindrome
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPalindromeSimple() {
            // vérification que la fonction passe le test simple
            Palindrome lepalindrome = new Palindrome();
            Assert.IsTrue(lepalindrome.verifierPalindrome("bob"));
            Assert.IsTrue(lepalindrome.verifierPalindrome("BOB"));
        }
        [TestMethod]
        public void TestPalindromeMinMaj() {
            // vérification que la fonction passe le test simple
            Palindrome lepalindrome = new Palindrome();
            Assert.IsTrue(lepalindrome.verifierPalindrome("Bob"));
            Assert.IsTrue(lepalindrome.verifierPalindrome("AnNa"));
        }
        [TestMethod]
        public void TestPalindromeAccents() {
            // vérification que la fonction passe le test des accents
            Palindrome lepalindrome = new Palindrome();
            Assert.IsTrue(lepalindrome.verifierPalindrome("RéussiràParissuer"));
        }
        [TestMethod]
        public void TestPalindromeCarSpeciaux() {
            // vérification que la fonction passe le test des caractères à supprimer
            Palindrome lepalindrome = new Palindrome();
            Assert.IsTrue(lepalindrome.verifierPalindrome("Reussir a Paris : suer"));
        }
        [TestMethod]
        public void TestPalindromeErreur() {
            Palindrome lepalindrome = new Palindrome();
            Assert.IsFalse(lepalindrome.verifierPalindrome("B0B"));
            Assert.IsFalse(lepalindrome.verifierPalindrome("Pas un palindrome"));
        }
    }
}