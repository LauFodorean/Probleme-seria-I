using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

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
            string firstPassword ="";
            string secondPassword ="";
            firstPassword = GeneratePassword(10);
            int milliseconds = 3000;
            Thread.Sleep(milliseconds);
            secondPassword = GeneratePassword(10);
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
