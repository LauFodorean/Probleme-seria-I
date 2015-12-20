using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anagram
{
    [TestClass]
    public class AnagramationUnitTest
    {
        [TestMethod]
        public void ThreeLettersWordTestMethod()
        {
            Assert.AreEqual(6, NumberOfWordAnagramations("abc"));
        }

        [TestMethod]
        public void SixLettersWordTestMethod()
        {
            Assert.AreEqual(720, NumberOfWordAnagramations("delfin"));
        }

        [TestMethod]
        public void WordWithRepeatingCharactersTestMethod()
        {
            Assert.AreEqual(60, NumberOfWordAnagramations("apple"));
        }

        [TestMethod]
        public void CalculateFactorialTestMethod()
        {
            Assert.AreEqual(6, Factorial(3));
        }

        [TestMethod]
        public void CalculateDididingNumberTestMethod()
        {
            Assert.AreEqual(2, CalculateDividingNumber("apple","aple"));
        } 
                
       public int NumberOfWordAnagramations(string word)
        {
           int numberOfAnagrams = 1;
           int lettersInWord = word.Length;
           string initialWord = word;
           string wordWithoutRepeatingCharacters = "";
           RemoveRepeatingCharacters(ref word, ref wordWithoutRepeatingCharacters);
           int dividingNumber = CalculateDividingNumber(initialWord, wordWithoutRepeatingCharacters);
           numberOfAnagrams = Factorial(lettersInWord) / dividingNumber;
           return numberOfAnagrams;
           
        }

       private static void RemoveRepeatingCharacters(ref string word, ref string wordWithoutRepeatingCharacters)
       {
           
           while (word != "")
           {
               string characterToReplace = "";
               characterToReplace = characterToReplace + word[0];
               wordWithoutRepeatingCharacters = wordWithoutRepeatingCharacters + characterToReplace;
               word = word.Replace(characterToReplace, "");
           }
       }
          private static int CalculateDividingNumber(string initialWord, string wordWithoutRepeatingCharacters)
       {
           int dividingNumber = 1;
           for (int j = 0; j < wordWithoutRepeatingCharacters.Length; j++)
           {
               int contor = 0;
               for (int l = 0; l < initialWord.Length; l++)
               {
                   if (wordWithoutRepeatingCharacters[j] == initialWord[l])
                       contor += 1;
               }

               dividingNumber = dividingNumber * Factorial(contor);
           }
           return dividingNumber;
       }

       private static int Factorial(int numberOfLettersInWord)
       {
           int numberOfAnagrams = 1;
           for (int i = 1; i <= numberOfLettersInWord; i++)
               numberOfAnagrams = numberOfAnagrams * i;
           return numberOfAnagrams;
       }
    }
}
