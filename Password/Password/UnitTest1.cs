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

        public int GetNumberOfBigLettersFromPassword(string password)
        {
            int number = 0;
            for (int i = 0; i < password.Length; i++)
                if (char.IsUpper(password[i]))
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
            string smallLettersPassword = "";
            var character = new Random();
            char passwordCharacter;
            for (int i = 0; i < numberOfCharacters; i++)
            {
                passwordCharacter = (char)character.Next('a', 'z');
                smallLettersPassword = smallLettersPassword + passwordCharacter;

            }
            return smallLettersPassword;
        }

        public string GeneratePassword(passwordsettings numberOfCharacters)
        {
            string password = "";
            password = GenerateSmallLetters(numberOfCharacters.numberOfSmallLetters) + GenerateBigLetters(numberOfCharacters.numberOfBigLetters);
            return password;
        }
        
    }
}
