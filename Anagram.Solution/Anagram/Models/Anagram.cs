using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Anagram.Models
{
    public class Word
    {
        public string Base { get; set; }
        private List<string> _anagrams;

        public Word(List<string> words, string word)
        {
            _anagrams = words;
            Base = word;
        }
        public List<string> AnagramChecker(Word word)
        {
            List<string> list = word._anagrams;
            List<string> successfulAnagrams = new List<string>{};
            foreach (string item in list)
            {
                if(WordChecker(item, word.Base) == true){
                    successfulAnagrams.Add(item);
                }
            }
            return successfulAnagrams;
        }

        public bool WordChecker(string item, string word)
        {
            int counter = 0;
            char[] itemLetters = item.ToUpper().ToCharArray();
            char[] letters = word.ToUpper().ToCharArray();
            for (int j = 0; j < itemLetters.Length; j++)
            {
                for (int i = 0; i < letters.Length; i++)
                {
                    if (LetterChecker(letters[i], itemLetters[j]) == true)
                    {
                        counter++;
                        letters = new string(letters).Remove(i,1).ToCharArray();
                        break;
                    }
                }
            }
            if (counter == word.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool LetterChecker(char item, char letter)
        {
            if(item.Equals(letter))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
