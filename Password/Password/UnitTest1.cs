using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace Password
{
    [TestClass]
    public class UnitTest1
    {
        public struct passwordsettings
        {
            public int numberOfSmallLetters;
            public int numberOfBigLetters;
            public int numberOfFigures;
            public int numberOfSymbols;
            public passwordsettings(int numberOfSmallLetters, int numberOfBigLetters, int numberOfFigures, int numberOfSymbols)
            {
                this.numberOfSmallLetters = numberOfSmallLetters;
                this.numberOfBigLetters = numberOfBigLetters;
                this.numberOfFigures = numberOfFigures; ;
                this.numberOfSymbols = numberOfSymbols;
            }
        }

        public enum passwordCharacters
        {
            smallCaps,
            upperCaps,
            figures
        }



        [TestMethod]
        public void CheckNumberOfCharactersInPasswordWhenBigAndSmallLettters()
        {
            passwordsettings settings = new passwordsettings { numberOfSmallLetters = 10, numberOfBigLetters = 3 };
            Assert.AreEqual(13, GeneratePassword(settings).Length);
        }
        
        [TestMethod]
        public void CheckIfPasswordHasTheReqiuredLength()
        {
            passwordsettings settings = new passwordsettings { numberOfSmallLetters = 12 };
            Assert.AreEqual(12, GeneratePassword(settings).Length);
        }

        [TestMethod]
        public void CheckIfPasswordHasOnlySmallLetters()
        {
            passwordsettings settings = new passwordsettings { numberOfSmallLetters = 10 };
            Assert.AreEqual(true, CheckPasswordToSeeIfITHasOnlySmallLetters(GeneratePassword(settings)));
        }

        [TestMethod]
        public void CheckForSmallLetters()
        {
            Assert.AreEqual(true, CheckPasswordToSeeIfITHasOnlySmallLetters("abc"));
        }

        [TestMethod]
        public void CheckPaswordForSmallLetersWhenItHasAlsoBigLetters()
        {
            Assert.AreEqual(false, CheckPasswordToSeeIfITHasOnlySmallLetters("abDcF"));
        }


        //[TestMethod]
        //public void CheckPaswordForNumberBigLetters()
        //{
        //    Assert.AreEqual(false, CheckPasswordBigLetters("abDcF"));
        //}

        [TestMethod]
        public void CheckPaswordForNumberBigLetters()
        {
            Assert.AreEqual(2, GetNumberOfBigLettersFromPassword("abDcF"));
        }

        [TestMethod]
        public void CheckPaswordForNumberofFigures()
        {
            Assert.AreEqual(3, GetNumberOfFigures("1abD2c3F"));
        }

        [TestMethod]
        public void CheckForNumberofSymbols()
        {
            Assert.AreEqual(3, GetNumberOfSymbols("1ab#D2c3@F!"));
        }

        [TestMethod]
        public void CheckSymbolsGeneration()
        {
            Assert.AreEqual(6, GetNumberOfSymbols(GenerateSymbols(6)));
        }

        [TestMethod]
        public void CheckStringOfFiguresThatContainsFigureOne()
        {
            Assert.AreEqual(true, FunctionThatChecksIfStringContainsNotAllowedCharacters("2369631875"));
        }

        [TestMethod]
        public void CheckStringOfFiguresThatContainsFigureZero()
        {
            Assert.AreEqual(true, FunctionThatChecksIfStringContainsNotAllowedCharacters("2369630875"));
        }

        [TestMethod]
        public void CheckStringOfFiguresThatDoesNotContainFiguresZeroOrOne()
        {
            Assert.AreEqual(false, FunctionThatChecksIfStringContainsNotAllowedCharacters("236963875"));
        }

        [TestMethod]
        public void CheckGeneratedStringOfFiguresSoThatItDoesntCointainFiguresOneAndZero()
        {
            Assert.AreEqual(false, FunctionThatChecksIfStringContainsNotAllowedCharacters(GenerateCharacters(8,passwordCharacters.figures)));
        }

         [TestMethod]
        public void CheckStringOfSmallLettersThatContainsSmallLetterL()
        {
            Assert.AreEqual(true, FunctionThatChecksIfStringContainsNotAllowedCharacters("abcdefglmng"));
        }

         [TestMethod]
         public void CheckGeneratedStringOfSmallLettersSoThatItDoesntCointainlettersLandO()
         {
             Assert.AreEqual(false, FunctionThatChecksIfStringContainsNotAllowedCharacters(GenerateCharacters(8,passwordCharacters.figures)));
         }

         [TestMethod]
         public void CheckStringOfBigLettersThatContainsBigLetterL()
         {
             Assert.AreEqual(true, FunctionThatChecksIfStringContainsNotAllowedCharacters("ABCDEFGLHUT"));
         }

         [TestMethod]
         public void CheckGeneratedStringOfBigLettersSoThatItDoesntCointainlettersLandO()
         {
             Assert.AreEqual(false, FunctionThatChecksIfStringContainsNotAllowedCharacters(GenerateCharacters(8,passwordCharacters.figures)));
         }

         [TestMethod]
         public void CheckTheReturnedRangeOfCharacters()
         {
             CollectionAssert.AreEqual(new int[] { 'a','z' }, GiveCharacterRangeForRandomGenerator(passwordCharacters.smallCaps));
         }

         [TestMethod]
         public void CheckIFTheReturnedCharacterIsAmbiguous()
         {
             Assert.AreEqual(true, CheckIfCharacterIsAmbiguous('{'));
         }

         [TestMethod]
         public void CheckPasswordRandomization()
         {
             string firstPassword = "";
             string secondPassword = "";
             firstPassword = Randomization("kdgft");
             int milliseconds = 3000;
             Thread.Sleep(milliseconds);
             secondPassword = Randomization("kdgft");
             Assert.AreNotEqual(firstPassword, secondPassword);
         }

        [TestMethod]
        public void CheckIfTwoGeneratedPasswordsAreRandom()
        {
            string firstPassword ="";
            string secondPassword ="";
            passwordsettings settings = new passwordsettings { numberOfSmallLetters = 10 };
            firstPassword = GeneratePassword(settings);
            int milliseconds = 3000;
            Thread.Sleep(milliseconds);
            secondPassword = GeneratePassword(settings);
            Assert.AreNotEqual(firstPassword, secondPassword);
        }

        [TestMethod]
        public void CheckIfGeneratedSymbolsAreRandom()
        {
            string firstString = "";
            string secondString = "";
            passwordsettings settings = new passwordsettings { numberOfSymbols = 10 };
            firstString = GenerateSymbols(settings.numberOfSymbols);
            int milliseconds = 3000;
            Thread.Sleep(milliseconds);
            secondString = GenerateSymbols(settings.numberOfSymbols);
            Assert.AreNotEqual(firstString, secondString);
        }

        public int GetNumberOfBigLettersFromPassword(string password)
        {
            int number = 0;
            for (int i = 0; i < password.Length; i++)
                if (char.IsUpper(password[i]))
                    number++;
            return number;
        }

        public int GetNumberOfFigures(string password)
        {
            int number = 0;
            for (int i = 0; i < password.Length; i++)
                if (char.IsDigit(password[i]))
                    number++;
            return number;
        }

        public int GetNumberOfSymbols(string password)
        {
            int number = 0;
            string symbols = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";
            for (int i = 0; i < password.Length; i++)
                for (int j = 0; j < symbols.Length; j++ )
                    if (password[i]==symbols[j])
                        number++;
            return number;
        }

        public bool CheckPasswordToSeeIfITHasOnlySmallLetters(string password)
        {
            bool smallLetter = true;
            for (int i = 0; i < password.Length; i++)
                if (char.IsUpper(password[i]))
                    smallLetter = false;
            return smallLetter;
        }

        public int[] GiveCharacterRangeForRandomGenerator( passwordCharacters typeOfCharacters)
        {
            int[] rangeOfCharacters = new int[] { };
            switch (typeOfCharacters)
            {
                case passwordCharacters.smallCaps:
                    rangeOfCharacters = new int[] { 'a', 'z' };
                    break;
                case passwordCharacters.upperCaps:
                    rangeOfCharacters = new int[] { 'A', 'Z' };
                    break;
                case passwordCharacters.figures:
                    rangeOfCharacters = new int[] { '0', '9' };
                    break;
            }
            return rangeOfCharacters;
        }

        public string GenerateCharacters(int numberOfCharacters, passwordCharacters typeOfCharacters)
        {
            string characters = "";
            var character = new Random();
            int[] range = new int[] { };
            range = GiveCharacterRangeForRandomGenerator(typeOfCharacters);
            char passwordCharacter;
            for (int i = 0; i < numberOfCharacters; i++)
            {
                passwordCharacter = (char)character.Next(range[0],range[range.Length-1]);
                if (passwordCharacter != '0' && passwordCharacter != '1' && passwordCharacter != 'l' && passwordCharacter != 'o')
                    characters = characters + passwordCharacter;
                else
                    i--;

            }
            return characters;
        }

        public string GenerateSymbols(int numberOfCharacters)
        {
            string passwordSymbols = "";
            var character = new Random();
            char passwordCharacter;
            bool ambiguousCharacter = false;
            for (int i = 0; i < numberOfCharacters; i++)
            {
                passwordCharacter = (char)character.Next('!','~');
                if (char.IsLetterOrDigit(passwordCharacter))
                    i--;
                else
                {
                    ambiguousCharacter = CheckIfCharacterIsAmbiguous(passwordCharacter);
                    if (ambiguousCharacter == true)
                        i--;
                    else
                        passwordSymbols = passwordSymbols + passwordCharacter;
                }
                ambiguousCharacter = false;
            }
            return passwordSymbols;
        }

        public bool CheckIfCharacterIsAmbiguous(char character)
        {
            bool ambiguousCharacter = false;
            string ambiguousChars = "{}[]()/\'\"~,;.<>";
            for ( int j = 0; j < ambiguousChars.Length; j++)
                        if (ambiguousChars[j] == character)
                            ambiguousCharacter = true;
            return ambiguousCharacter;       
        }

        public bool FunctionThatChecksIfStringContainsNotAllowedCharacters(string generatedString)
        {
            bool confirmationOfPresence = false;
            for (int i = 0; i < generatedString.Length; i++)
                if (generatedString[i] == '1' || generatedString[i] == '0' || generatedString[i] == 'l' || generatedString[i] == 'o' || generatedString[i] == 'L' || generatedString[i] == 'O')
                    confirmationOfPresence = true;
            return confirmationOfPresence;
        }
                
        public string GeneratePassword(passwordsettings numberOfCharacters)
        {
            string password = "";
            password = GenerateCharacters(numberOfCharacters.numberOfSmallLetters, passwordCharacters.smallCaps) + GenerateCharacters(numberOfCharacters.numberOfBigLetters, passwordCharacters.upperCaps) + GenerateCharacters(numberOfCharacters.numberOfFigures,passwordCharacters.figures)+ GenerateSymbols(numberOfCharacters.numberOfSymbols);
            password = Randomization(password);
            return password;
        }

        public string Randomization(string password)
        {
            bool existingCharacter = false;
            var character = new Random();
            char passwordCharacter;
            string passwordWithRemovedCharacters = password;
            string randomizedPassword = "";
            for (int i = 0; i < password.Length; i++)
            {
                passwordCharacter = (char)character.Next('!', '~');
                int j = 0;
                while (j < passwordWithRemovedCharacters.Length)
                { 
                    if (passwordCharacter == passwordWithRemovedCharacters[j])
                    {
                        existingCharacter = true;
                        break;
                    }
                    else
                        j++;
                }
                if (existingCharacter == true)
                {
                    string range1 = "";
                    string range2 = "";
                    for (int k = 0; k < j; k++)
                        range1 = range1 + passwordWithRemovedCharacters[k];
                    for (int z = j + 1; z < passwordWithRemovedCharacters.Length; z++)
                        range2 = range2 + passwordWithRemovedCharacters[z];
                    passwordWithRemovedCharacters = range1 + range2;
                    randomizedPassword = randomizedPassword + passwordCharacter;
                    
                }
                else
                    i--;
                existingCharacter = false;
                
            }
            return randomizedPassword;
        }
    }
}
