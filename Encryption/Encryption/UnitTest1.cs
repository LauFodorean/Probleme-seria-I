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
            Assert.AreEqual("14725h36i", message);

        }

        [TestMethod]
        public void EcryptedTextTestMethod()
        {

            string message = EncryptMessage("1234567");
            Assert.AreEqual("14725h36i", message);

        }

        [TestMethod]
        public void EcryptedTextTestMethod2()
        {

            string message = EncryptMessage("nicaieri nu e ca acas");
            Assert.AreEqual("nraiiacncauaiesecs", message);

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
                numberOfRows = NumberOfRowsCalculus(encryptedText, numberOfColumns) + 1;
            else
                numberOfRows = NumberOfRowsCalculus(encryptedText, numberOfColumns);
            char[,] lettersInMatrix = new char[numberOfColumns, numberOfRows];
            int k = 0;
            k = MatrixPopulation(encryptedText, alphabet, numberOfColumns, numberOfRows, lettersInMatrix, k);
            encryptedText = "";
            encryptedText = AddingToStringFromMatrix(encryptedText, numberOfColumns, numberOfRows, lettersInMatrix);

            return encryptedText;
        }

        private static string AddingToStringFromMatrix(string encryptedText, int numberOfColumns, int numberOfRows, char[,] lettersInMatrix)
        {
            for (int j = 0; j < numberOfRows; j++)
                for (int i = 0; i < numberOfColumns; i++)
                {
                    encryptedText = encryptedText + lettersInMatrix[i, j];
                }
            return encryptedText;
        }

        private static int MatrixPopulation(string encryptedText, char[] alphabet, int numberOfColumns, int numberOfRows, char[,] lettersInMatrix, int k)
        {
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
            return k;
        }

        private static int NumberOfRowsCalculus(string encryptedText, int numberOfColumns)
        {
            return (encryptedText.Length / numberOfColumns);
        }

    }
}
