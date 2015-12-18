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
            Assert.AreEqual(6, wordAnagramation("abc"));
        }

        [TestMethod]
        public void SixLettersWordTestMethod()
        {
            Assert.AreEqual(720, wordAnagramation("delfin"));
        }

        [TestMethod]
        public void WordWithRepeatingCharactersTestMethod()
        {
            Assert.AreEqual(60, wordAnagramation("apple"));
        } 
                
       public int wordAnagramation(string word)
        {
           int numberOfAnagrams = 1;
           int lettersInWord = word.Length;
           int dividingNumber = 1;
           string initialWord = word;
           string wordWithoutRepeatingCharacters = "";
           int i = 0;
           RemoveRepeatingCharacters(ref word, ref wordWithoutRepeatingCharacters, i);
           dividingNumber = CalculateDividingNumber(dividingNumber, initialWord, wordWithoutRepeatingCharacters);
           numberOfAnagrams = Factorial(lettersInWord) / dividingNumber;
           return numberOfAnagrams;
           
        }

       private static int CalculateDividingNumber(int dividingNumber, string initialWord, string wordWithoutRepeatingCharacters)
       {
           for (int j = 0; j < wordWithoutRepeatingCharacters.Length; j++)
           {
               int contor = 0;
               for (int l = 0; l < initialWord.Length; l++)
               {
                   if (wordWithoutRepeatingCharacters[j] == initialWord[l])
                       contor = contor + 1;
               }

               dividingNumber = dividingNumber * Factorial(contor);
           }
           return dividingNumber;
       }

       private static void RemoveRepeatingCharacters(ref string word, ref string wordWithoutRepeatingCharacters, int i)
       {
           while (word != "")
           {
               string characterToReplace = "";
               characterToReplace = characterToReplace + word[i];
               wordWithoutRepeatingCharacters = wordWithoutRepeatingCharacters + characterToReplace;
               word = word.Replace(characterToReplace, "");
           }
       }

       private static int Factorial(int lettersInWord)
       {
           int numberOfAnagrams = 1;
           for (int i = 1; i <= lettersInWord; i++)
               numberOfAnagrams = numberOfAnagrams * i;
           return numberOfAnagrams;
       }
    }
}
