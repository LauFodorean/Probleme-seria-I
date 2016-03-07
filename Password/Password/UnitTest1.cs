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
            string symbols = "!@#$%^&*_+-?=:";
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
            //string symbols = "!@#$%^&*-+_?=:";
            var character = new Random();
            char passwordCharacter;
            for (int i = 0; i < numberOfCharacters; i++)
            {
                passwordCharacter = (char)character.Next('!','&');
                //for (int j = 0; j < symbols.Length; j++)
                //    if (passwordCharacter == symbols[j])
                        passwordSymbols = passwordSymbols + passwordCharacter;
                    //else
                    //    i--;

            }
            return passwordSymbols;
        }

        public string GeneratePassword(passwordsettings numberOfCharacters)
        {
            string password = "";
            password = GenerateSmallLetters(numberOfCharacters.numberOfSmallLetters) + GenerateBigLetters(numberOfCharacters.numberOfBigLetters) + GenerateFigures(numberOfCharacters.numberOfFigures);
            return password;
        }
        
    }
}
