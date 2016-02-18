using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Password
{
    [TestClass]
    public class UnitTest1
    {
        //enum passwordCharacters
        //{
        //    smallCapsAlphabet = 1,
        //    bigCapsAlphabet = 2,
        //    figures = 3
        //}
        
        [TestMethod]
        public void SmallCapsPassword()
        {
            string characters = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Assert.AreEqual(true, GeneratePassword(characters, 8));
            //char[] ambiguousCharacters = new char[] { '{', '}', '[', ']', '(', ')', '/','\', ''', '~', ',', ';', '.', '<', '>' };
                       
        }

        public bool GeneratePassword(string charactersFiguresOrSimbols, int passwordLength)
        {
            char[] passwordChars = new char[passwordLength];
            var randomPassword = new Random();
            char[] smallCharacters = new char[] {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
            char[] password = new char[passwordLength];
            bool passwordCheck = false;
            int counter = 0;
            int i = 0;


            //for (int i = 0; i < passwordChars.Length; i++)
            while ( i < passwordChars.Length)
            {
                passwordChars[i] = charactersFiguresOrSimbols[randomPassword.Next(charactersFiguresOrSimbols.Length)];
                if (i > 0)
                    counter = 1;
                for ( int j = 0; j < smallCharacters.Length; j++)
                {
                    
                    if (passwordChars[i] == smallCharacters[j])
                        password[i] = passwordChars[i];
                    else
                        i = i - counter;
                    
                }
                
            }
                      

            for (int k = 0; i < password.Length; i++)
                for (int j = 0; j < smallCharacters.Length; j++)
                    if (password[k] == smallCharacters[j])
                        passwordCheck = true;
                    else
                        passwordCheck = false;
            return passwordCheck;
        }
    }
}
