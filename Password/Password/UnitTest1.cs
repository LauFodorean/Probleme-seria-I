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
            public passwordsettings( int numberOfSmallLetters,int numberOfBigLetters,int numberOfFigures,int numberOfSymbols)
            {
                this.numberOfSmallLetters = numberOfSmallLetters;
                this.numberOfBigLetters = numberOfBigLetters;
                this.numberOfFigures = numberOfFigures; ;
                this.numberOfSymbols = numberOfSymbols;
            }
        }
        
        //public enum passwordCharacters
        //{
        //    smallCapsAlphabet,
        //    bigCapsAlphabet,
        //    figures,
        //    symbols,
        //    ambiguousCharacters
        //}



        [TestMethod]
        public void CheckNumberOfCharactersInPasswordWhenBigAndSmallLettters()
        {
            passwordsettings settings;
            settings.numberOfSmallLetters = 10;
            settings.numberOfBigLetters = 3;
            settings.numberOfFigures = 0;
            settings.numberOfSymbols = 0;
            Assert.AreEqual(13, GeneratePassword(settings).Length);
        }
        
        [TestMethod]
        public void CheckIfPasswordHasTheReqiuredLength()
        {
            passwordsettings settings;
            settings.numberOfSmallLetters = 12;
            settings.numberOfBigLetters = 0;
            settings.numberOfFigures = 0;
            settings.numberOfSymbols = 0;
            Assert.AreEqual(12, GeneratePassword(settings).Length);
        }

        [TestMethod]
        public void CheckIfPasswordHasOnlySmallLetters()
        {
            passwordsettings settings;
            settings.numberOfSmallLetters = 10;
            settings.numberOfBigLetters = 0;
            settings.numberOfFigures = 0;
            settings.numberOfSymbols = 0;
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

        //[TestMethod]
        //public void RemoveAmbiguousCharactersTest()
        //{
        //    Assert.AreEqual(' ', AmbiguousCharacterRemoval('}'));
        //}

        [TestMethod]
        public void CheckIfTwoGeneratedPasswordsAreRandom()
        {
            string firstPassword ="";
            string secondPassword ="";
            passwordsettings settings;
            settings.numberOfSmallLetters = 10;
            settings.numberOfBigLetters = 0;
            settings.numberOfFigures = 0;
            settings.numberOfSymbols = 0;
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
            passwordsettings settings;
            settings.numberOfSmallLetters = 0;
            settings.numberOfBigLetters = 0;
            settings.numberOfFigures = 0;
            settings.numberOfSymbols = 10;
            firstString = GenerateSymbols(settings.numberOfSymbols);
            int milliseconds = 3000;
            Thread.Sleep(milliseconds);
            secondString = GenerateSymbols(settings.numberOfSymbols);
            Assert.AreNotEqual(firstString, secondString);
        }

        //[TestMethod]
        //public void CheckIfGeneratedSymbolsAreRandom()
        //{
        //    Assert.AreNotEqual(GenerateSymbols(10), GenerateSymbols(10));
        //}

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

        public string GenerateBigLetters(int numberOfLetters)
        {
            string bigLetters = "";
            var character = new Random();
            char passwordCharacter;
            for (int i = 0; i < numberOfLetters; i++)
            {
                passwordCharacter = (char)character.Next('A', 'Z');
                bigLetters = bigLetters + passwordCharacter;

            }
            return bigLetters;
        }

        public string GenerateSmallLetters(int numberOfCharacters)
        {
            string smallLetters = "";
            var character = new Random();
            char passwordCharacter;
            for (int i = 0; i < numberOfCharacters; i++)
            {
                passwordCharacter = (char)character.Next('a', 'z');
                smallLetters = smallLetters + passwordCharacter;

            }
            return smallLetters;
        }

        public string GenerateFigures(int numberOfCharacters)
        {
            string figures = "";
            var character = new Random();
            char passwordCharacter;
            for (int i = 0; i < numberOfCharacters; i++)
            {
                passwordCharacter = (char)character.Next('0', '9');
                figures = figures + passwordCharacter;

            }
            return figures;
        }

        public string GenerateSymbols(int numberOfCharacters)
        {
            string passwordSymbols = "";
            string ambiguousChars = "{}[]()/\'\"~,;.<>";
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
                    for ( int j = 0; j < ambiguousChars.Length; j++)
                        if (ambiguousChars[j] == passwordCharacter)
                            ambiguousCharacter = true;
                    if (ambiguousCharacter == true)
                        i--;
                    else
                        passwordSymbols = passwordSymbols + passwordCharacter;
                }
                ambiguousCharacter = false;
            }
            return passwordSymbols;
        }

        //public char AmbiguousCharacterRemoval(char character)
        //{
        //    string ambiguousChars = "{}[]()/\'\"~,;.<>";
        //    int i = 0, j = 0;
        //    char characterToBeReturned = ' ';
        //    while (j < ambiguousChars.Length)
        //          if (character == ambiguousChars[j])
        //              i--;
        //          else
        //              if (j == ambiguousChars.Length - 1)
        //                  characterToBeReturned = character;
        //    return characterToBeReturned;
        //}

        public string GeneratePassword(passwordsettings numberOfCharacters)
        {
            string password = "";
            password = GenerateSmallLetters(numberOfCharacters.numberOfSmallLetters) + GenerateBigLetters(numberOfCharacters.numberOfBigLetters) + GenerateFigures(numberOfCharacters.numberOfFigures)+GenerateSymbols(numberOfCharacters.numberOfSymbols);
            return password;
        }
        
    }
}
