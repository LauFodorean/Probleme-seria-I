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

        

        [TestMethod]
        public void CheckIfPasswordHasTheReqiuredLength()
        {
            Assert.AreEqual(12, GeneratePassword(12).Length);
        }

        [TestMethod]
        public void CheckIfPasswordHasOnlySmallLetters()
        {
            Assert.AreEqual(true, CheckPasswordToSeeIfITHasOnlySmallLetters(GeneratePassword(10)));
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
            Assert.AreEqual(true, GenerateTwoRandomPasswords(10));
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

        public bool GenerateTwoRandomPasswords(int numberOfCharacters)
        {
            string firstPassword = "";
            string secondPassword = "";
            bool passwordsAreRandom = false;
            int count = 0;
            
            AddCharactersToTheFirstAndToTheSecondPassword(numberOfCharacters);
            count = CountSimilarCharactersInTwoPasswords(firstPassword,secondPassword);
            if (count < numberOfCharacters)
                passwordsAreRandom = true;
            return passwordsAreRandom;
            
        }

        private static int CountSimilarCharactersInTwoPasswords( string firstPassword, string secondPassword)
        {
            int count = 0;
            for (int i = 0; i < firstPassword.Length ; i++)
            {
                if (firstPassword[i] == secondPassword[i])
                    count += 1;
            }
            return count;
        }

        private static void AddCharactersToTheFirstAndToTheSecondPassword(int numberOfCharacters)
        {
            string firstPassword = "";
            string secondPassword = "";
            var firstPasswordcharacter = new Random();
            var secondPasswordcharacter = new Random(3000);
            char characterForFirstPassword, characterForSecondPassword;
            
            for (int i = 0; i < numberOfCharacters; i++)
            {
                characterForFirstPassword = (char)firstPasswordcharacter.Next('a', 'z');
                characterForSecondPassword = (char)secondPasswordcharacter.Next('a', 'z');
                firstPassword = firstPassword + characterForFirstPassword;
                secondPassword = secondPassword + characterForSecondPassword;
            }
        }


        public string GeneratePassword(int numberOfCharacters)
        {
            string password = "";
            var character = new Random();
            char passwordCharacter;
            for (int i = 0; i < numberOfCharacters; i++)
            {
                passwordCharacter = (char)character.Next('a', 'z');
                password = password + passwordCharacter;
                
            }
            return password;
        }
        
    }
}
