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
            Assert.AreEqual(12, GeneratePassword(10));
        }

        [TestMethod]
        public void CheckForSmallLetters()
        {
            Assert.AreEqual(true, CheckPasswordToSeeIfITHasOnlySmallLetters("abc"));
        }

        public bool CheckPasswordToSeeIfITHasOnlySmallLetters(string password)
        {
            bool smallLetter = true;
            for (int i = 0; i < password.Length; i++)
                if (char.IsUpper(password[i]))
                    smallLetter = false;
            return smallLetter;
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
