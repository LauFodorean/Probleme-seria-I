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

        public string GeneratePassword(int numberOfCharacters)
        {
            string password = "";
            for (int i = 0; i < numberOfCharacters; i++)
                password = password + 'a';

            return password;
        }
        
    }
}
