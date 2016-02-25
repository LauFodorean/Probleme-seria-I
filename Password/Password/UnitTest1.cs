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
        
        //public enum passwordCharacters
        //{
        //    smallCapsAlphabet,
        //    bigCapsAlphabet,
        //    figures,
        //    symbols,
        //    ambiguousCharacters
        //}

        //public string[] CharactersToBeUsedForPassword(passwordCharacters pChars)
        //{
        //    string[] charactersForPassword = new string[1];
        //    switch (pChars)
        //    {
        //        case passwordCharacters.smallCapsAlphabet:
        //            charactersForPassword = new string[26] { "U+0061", "U+0062", "U+0063", "U+0064"
        //            , "U+0065", "U+0066", "U+0067", "U+0068", "U+0069", "U+006a", "U+006b", "U+006c"
        //            , "U+006d", "U+006e", "U+006f", "U+0070", "U+0071", "U+0072", "U+0073", "U+0074"
        //            , "U+0075", "U+0076", "U+0077", "U+0078", "U+0079", "U+007a"};
        //            break;
        //        case passwordCharacters.bigCapsAlphabet:
        //            charactersForPassword = new string[26] { "U+0041", "U+0042", "U+0043", "U+0044"
        //            , "U+0045", "U+0046", "U+0047", "U+0048", "U+0049", "U+004a", "U+0064", "U+004c"
        //            , "U+004d", "U+004e", "U+004f", "U+0050", "U+0051", "U+0052", "U+0053", "U+0054"
        //            , "U+0055", "U+0056", "U+0057", "U+0058", "U+0059", "U+005a"};
        //            break;
                //case passwordCharacters.figures:
                //    charactersForPassword = "0123456789";
                //    break;
                //case passwordCharacters.ambiguousCharacters:
                //    charactersForPassword = "{}[]()/\'"'~'','';''.'<>";
                //    break;
        //    }
        //    return charactersForPassword;
        //}

              
        [TestMethod]
        public void PasswordWithSmallCaps()
        {
            Assert.AreEqual(10, GeneratePassword(10,0,0,0));
        }

        [TestMethod]
        public void PasswordWithSmallCapsBigCaps()
        {
            Assert.AreEqual(6, GeneratePassword(2,4,0,0));
        }

        [TestMethod]
        public void PasswordWithSmallCapsBigCapsFigures()
        {
            Assert.AreEqual(9, GeneratePassword(2, 4, 3, 0));
        }

        [TestMethod]
        public void PasswordWithSmallCapsBigCapsFiguresAndSymbols()
        {
            Assert.AreEqual(12, GeneratePassword(2, 4, 5, 1));
        }

        public int GeneratePassword(int numberOfSmallCharacters, int numbersOfBigCharacters, int numberOfFigures, int numberOfSimbols)
        {
            int totalNumberOfCharsInPassword = numberOfSmallCharacters + numbersOfBigCharacters + numberOfFigures + numberOfSimbols;
            string[] similarCharacters = new string[] { "" };
            string[] passwordChars = new string[totalNumberOfCharsInPassword];
            int index;
            int counter = 0;
            bool smallCharacter_L = false;
            bool smallCharacter_O = false;
            string[] smallCharactersForPassword = new string[26] { "U+0061", "U+0062", "U+0063", "U+0064"
                    , "U+0065", "U+0066", "U+0067", "U+0068", "U+0069", "U+006A", "U+006B", "U+006C"
                    , "U+006D", "U+006E", "U+006F", "U+0070", "U+0071", "U+0072", "U+0073", "U+0074"
                    , "U+0075", "U+0076", "U+0077", "U+0078", "U+0079", "U+007A"};
            string[] bigCharactersForPassword = new string[26] { "U+0041", "U+0042", "U+0043", "U+0044"
                    , "U+0045", "U+0046", "U+0047", "U+0048", "U+0049", "U+004A", "U+0064", "U+004C"
                    , "U+004D", "U+004E", "U+004F", "U+0050", "U+0051", "U+0052", "U+0053", "U+0054"
                    , "U+0055", "U+0056", "U+0057", "U+0058", "U+0059", "U+005A"};
            string[] figuresForPassword = new string[10] { "U+0030", "U+0031", "U+0032", "U+0033"
                    , "U+0034", "U+0035", "U+0036", "U+0037", "U+0038", "U+0039"};
            string[] symbolsForPassword = new string[14] { "U+0021", "U+0023", "U+0024", "U+0025"
                    , "U+0026", "U+002A", "U+002B", "U+002D", "U+003A", "U+003D", "U+003F", "U+0040",
                    "U+005E", "U+005F"};
            var randomPasswordCharacter = new Random();
            for (int i = 0; i < numberOfSmallCharacters; i++)
            {
                index = randomPasswordCharacter.Next(0, smallCharactersForPassword.Length);
                if (smallCharactersForPassword[index] == "U+006C" || smallCharactersForPassword[index] == "U+006F")
                {
                    switch (smallCharactersForPassword[index])
                    {
                        case ("U+006C"):
                            if (smallCharacter_L == false)
                            {
                                passwordChars[i] = smallCharactersForPassword[index];
                                smallCharacter_L = true;
                                counter++;
                            }
                            else
                                i = i - 1;
                            break;
                        case ("U+006F"):
                            if (smallCharacter_O == false)
                            {
                                passwordChars[i] = smallCharactersForPassword[index];
                                smallCharacter_O = true;
                                counter++;
                            }
                            else
                                i = i - 1;
                            break;
                    }
                }
                else
                {
                    passwordChars[i] = smallCharactersForPassword[index];
                    counter++;
                }
                
            }
            for (int i = numberOfSmallCharacters; i < numberOfSmallCharacters + numbersOfBigCharacters ; i++)
            {
                index = randomPasswordCharacter.Next(0, bigCharactersForPassword.Length);
                passwordChars[i] = bigCharactersForPassword[index];
                counter++;
            }
            for (int i = numberOfSmallCharacters + numbersOfBigCharacters; i < numberOfSmallCharacters + numbersOfBigCharacters + numberOfFigures; i++)
            {
                index = randomPasswordCharacter.Next(0, figuresForPassword.Length);
                passwordChars[i] = figuresForPassword[index];
                counter++;
            }
            for (int i = numberOfSmallCharacters + numbersOfBigCharacters + numberOfFigures; i < totalNumberOfCharsInPassword; i++)
            {
                index = randomPasswordCharacter.Next(0, symbolsForPassword.Length);
                passwordChars[i] = figuresForPassword[index];
                counter++;
            }

        return counter;
        }
    }
}
