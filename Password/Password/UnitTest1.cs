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
                case passwordCharacters.bigCapsAlphabet:
                    charactersForPassword = new string[26] { "U+0041", "U+0042", "U+0043", "U+0044"
                    , "U+0045", "U+0046", "U+0047", "U+0048", "U+0049", "U+004a", "U+0064", "U+004c"
                    , "U+004d", "U+004e", "U+004f", "U+0050", "U+0051", "U+0052", "U+0053", "U+0054"
                    , "U+0055", "U+0056", "U+0057", "U+0058", "U+0059", "U+005a"};
                    break;
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
        public void PasswordWithSmallCaps()
        {
            Assert.AreEqual(10, GeneratePassword(10,0,0,0));
        }

        [TestMethod]
        public void PasswordWithBigCaps()
        {
            Assert.AreEqual(6, GeneratePassword(2,4,0,0));
        }

        public int GeneratePassword(int numberOfSmallCharacters, int numbersOfBigCharacters, int numberOfFigures, int numberOfSimbols)
        {
            int totalNumberOfCharsInPassword = numberOfSmallCharacters + numbersOfBigCharacters + numberOfFigures + numberOfSimbols;
            string[] passwordChars = new string[totalNumberOfCharsInPassword];
            int index;
            int counter = 0;
            string[] smallCharactersForPassword = new string[26] { "U+0061", "U+0062", "U+0063", "U+0064"
                    , "U+0065", "U+0066", "U+0067", "U+0068", "U+0069", "U+006a", "U+006b", "U+006c"
                    , "U+006d", "U+006e", "U+006f", "U+0070", "U+0071", "U+0072", "U+0073", "U+0074"
                    , "U+0075", "U+0076", "U+0077", "U+0078", "U+0079", "U+007a"};
            string[] bigCharactersForPassword = new string[26] { "U+0041", "U+0042", "U+0043", "U+0044"
                    , "U+0045", "U+0046", "U+0047", "U+0048", "U+0049", "U+004a", "U+0064", "U+004c"
                    , "U+004d", "U+004e", "U+004f", "U+0050", "U+0051", "U+0052", "U+0053", "U+0054"
                    , "U+0055", "U+0056", "U+0057", "U+0058", "U+0059", "U+005a"};
            var randomPasswordCharacter = new Random();
            for (int i = 0; i < totalNumberOfCharsInPassword - (numbersOfBigCharacters + numberOfFigures + numberOfSimbols); i++)
            {
                index = randomPasswordCharacter.Next(0, smallCharactersForPassword.Length);
                passwordChars[i] = smallCharactersForPassword[index];
                counter++;
            }
            for (int i = numberOfSmallCharacters; i < numberOfSmallCharacters + numbersOfBigCharacters ; i++)
            {
                index = randomPasswordCharacter.Next(0, bigCharactersForPassword.Length);
                passwordChars[i] = smallCharactersForPassword[index];
                counter++;
            }
        return counter;
        }
    }
}
