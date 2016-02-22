using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Password
{
    [TestClass]
    public class UnitTest1
    {
        public struct password
        {
            string passwordCharacters;
            int numberOfCharacters;
            public password(string pc, int numbers)
            {
                this.passwordCharacters = pc;
                this.numberOfCharacters = numbers;
            }
        }
        
        public enum passwordCharacters
        {
            smallCapsAlphabet,
            bigCapsAlphabet,
            figures,
            symbols,
            ambiguousCharacters
        }

        public string CharactersToBeUsedForPassword(passwordCharacters pChars)
        {
            string charactersForPassword = " ";
            switch (pChars)
            {
                case passwordCharacters.smallCapsAlphabet:
                    charactersForPassword = "abcdefghijklmnopqrstuvwxyz";
                    break;
                case passwordCharacters.bigCapsAlphabet:
                    charactersForPassword = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    break;
                case passwordCharacters.figures:
                    charactersForPassword = "0123456789";
                    break;
                //case passwordCharacters.ambiguousCharacters:
                //    charactersForPassword = "{}[]()/\'"'~'','';''.'<>";
                //    break;
            }
            return charactersForPassword;

        }
        
        [TestMethod]
        public void SmallCapsPassword()
        {
            Assert.AreEqual(true, GeneratePassword(CharactersToBeUsedForPassword(passwordCharacters.smallCapsAlphabet), 8));
            
                       
        }

        public password GeneratePassword(passwordCharacters charactersFiguresOrSimbols, int passwordLength)
        {
            string passwordChars = "";
            string charsToBeUsedInPassword = "";
            var randomPasswordCharacter = new Random();
            for (int i = 1; i <=passwordLength; i++ )
            {
                charsToBeUsedInPassword = CharactersToBeUsedForPassword(charactersFiguresOrSimbols);
                passwordChars = passwordChars + charsToBeUsedInPassword[randomPassword.Next(charsToBeUsedInPassword.Length)];
            }
            
            
            
            
            
            
            
            
            //char[] smallCharacters = new char[] {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
            //char[] password = new char[passwordLength];
            //bool passwordCheck = false;
            //int counter = 0;
            //int i = 0;


            ////for (int i = 0; i < passwordChars.Length; i++)
            //while ( i < passwordChars.Length)
            //{
            //    passwordChars[i] = charactersFiguresOrSimbols[randomPassword.Next(charactersFiguresOrSimbols.Length)];
            //    if (i > 0)
            //        counter = 1;
            //    for ( int j = 0; j < smallCharacters.Length; j++)
            //    {
                    
            //        if (passwordChars[i] == smallCharacters[j])
            //            password[i] = passwordChars[i];
            //        else
            //            i = i - counter;
                    
            //    }
                
            //}
                      

            //for (int k = 0; i < password.Length; i++)
            //    for (int j = 0; j < smallCharacters.Length; j++)
            //        if (password[k] == smallCharacters[j])
            //            passwordCheck = true;
            //        else
            //            passwordCheck = false;
            //return passwordCheck;
        }
    }
}
