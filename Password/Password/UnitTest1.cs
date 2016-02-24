using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Password
{
    [TestClass]
    public class UnitTest1
    {
        //public struct password
        //{
        //    string passwordCharacters;
        //    int numberOfCharacters;
        //    public password(string pc, int numbers)
        //    {
        //        this.passwordCharacters = pc;
        //        this.numberOfCharacters = numbers;
        //    }
        //}
        
        public enum passwordCharacters
        {
            smallCapsAlphabet,
            bigCapsAlphabet,
            figures,
            symbols,
            ambiguousCharacters
        }

        public string[] CharactersToBeUsedForPassword(passwordCharacters pChars)
        {
            string[] charactersForPassword = new string[1];
            switch (pChars)
            {
                case passwordCharacters.smallCapsAlphabet:
                    charactersForPassword = new string[26] { "U+0061", "U+0062", "U+0063", "U+0064"
                    , "U+0065", "U+0066", "U+0067", "U+0068", "U+0069", "U+006a", "U+006b", "U+006c"
                    , "U+006d", "U+006e", "U+006f", "U+0070", "U+0071", "U+0072", "U+0073", "U+0074"
                    , "U+0075", "U+0076", "U+0077", "U+0078", "U+0079", "U+007a"};
                    break;
                //case passwordCharacters.bigCapsAlphabet:
                //    charactersForPassword = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                //    break;
                //case passwordCharacters.figures:
                //    charactersForPassword = "0123456789";
                //    break;
                //case passwordCharacters.ambiguousCharacters:
                //    charactersForPassword = "{}[]()/\'"'~'','';''.'<>";
                //    break;
            }
            return charactersForPassword;
        }
        
        [TestMethod]
        public void NumbersOfCharactersInPassword()
        {
            Assert.AreEqual(10, GeneratePassword(CharactersToBeUsedForPassword(passwordCharacters.smallCapsAlphabet)));
            
                       
        }
        
        public int GeneratePassword(string[] passwordCharacters)
        {
            int numbersOfCharactersInPassword = 10;
            string[] passwordChars = new string[numbersOfCharactersInPassword];
            int index;
            var randomPasswordCharacter = new Random();
            for (int i = 0; i < passwordChars.Length; i++)
            {
                index = randomPasswordCharacter.Next(0, passwordCharacters.Length);
                passwordChars[i] = passwordCharacters[index];
            }
        return passwordChars.Length;
                  
        }
    }
}
