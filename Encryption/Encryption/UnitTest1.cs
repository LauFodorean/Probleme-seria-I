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

        [TestMethod]
        public void EcryptedTextTestMethod()
        {

            string message = EncryptMessage("1234567");
            Assert.AreEqual("14725h36i", message);

        }


        public string EncryptMessage(string pmessage)
        {
            string encryptedText;
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            encryptedText = pmessage.Replace(".", "").Replace(" ", "").Replace("-", "").Replace(",", "").Replace(";", "");
            int numberOfColumns = 3;
            int numberOfRows;
            int restOfDivision = encryptedText.Length % numberOfColumns;
            if (restOfDivision != 0)
                numberOfRows = (encryptedText.Length / numberOfColumns) + 1;
            else
                numberOfRows = encryptedText.Length / numberOfColumns;
            char[,] lettersInMatrix = new char[numberOfColumns, numberOfRows];
            int k = 0;
            for (int i = 0; i < numberOfColumns; i++)
                for (int j = 0; j < numberOfRows; j++)
                {
                    char[,] matrix = new char[numberOfColumns, numberOfRows];
                    if (k < encryptedText.Length)
                        lettersInMatrix[i, j] = encryptedText[k];
                    else
                        lettersInMatrix[i, j] = alphabet[k];

                    k = k + 1;
                }
            encryptedText = "";
            for (int j = 0; j < numberOfRows; j++)
                for (int i = 0; i < numberOfColumns; i++)
                {
                    encryptedText = encryptedText + lettersInMatrix[i, j];
                }

            return encryptedText;
        }

    }
}
