using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Encryption
{
    [TestClass]
    public class EncryptUnitTest
    {

        [TestMethod]
        public void PunctuationAndBlankRemovalTestMethod()
        {

            string message = EncryptMessage(" 123 45.67");
            Assert.AreEqual("1234567", message);

        }

        public string EncryptMessage(string pmessage)
        {
            string encryptedText;
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            encryptedText = pmessage.Replace(".", "").Replace(" ", "").Replace("-", "").Replace(",", "").Replace(";", "");
            return encryptedText;
        }

    }
}
