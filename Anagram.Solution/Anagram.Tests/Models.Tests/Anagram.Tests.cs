using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;

namespace Anagram.Tests
{
    [TestClass]
    public class WordTest
    {
        [TestMethod]
        public void WordChecker_WillCheckWordsForMatch_True()
        {
            List<string> otherWords = new List<string> {"jo", "betty", "joshua", "Drow", "hi", "nope", "Rowd"};
            Word newWord = new Word(otherWords, "Word");
            string word = "word";
            string drow = "drow";
            Assert.AreEqual(true, newWord.WordChecker(drow, word));
        }
        [TestMethod]
        public void LetterChecker_WillCheckLettersForMatch_True()
        {
            List<string> otherWords = new List<string> {"jo", "betty", "joshua", "Drow", "hi", "nope", "Rowd"};
            Word newWord = new Word(otherWords, "Word");
            string word = "o";
            string drow = "o";
            Assert.AreEqual(true, newWord.WordChecker(drow, word));
        }
        [TestMethod]
        public void AnagramChecker_WillCheckListForAnagrams_List()
        {
            List<string> words = new List<string> {"Drow", "Rowd"};
            List<string> otherWords = new List<string> {"jo", "betty", "joshua", "Drow", "hi", "nope", "Rowd"};
            Word newWord = new Word(otherWords, "Word");

            CollectionAssert.AreEqual(words, newWord.AnagramChecker(newWord));
        }
    }
}
