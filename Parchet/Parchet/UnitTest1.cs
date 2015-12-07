using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Parchet
{
    [TestClass]
    public class Parchet
    {
        [TestMethod]
        public void PiecesOfParquetOnOneDirection()
        {

            Assert.AreEqual(9, ParquetCalculation(7.55, 0.15, 1.00, 0.15));
        }

        [TestMethod]
        public void NeccesaryPiecesOfParquet()
        {

            Assert.AreEqual(21, ParquetCalculation(7.55, 0.35, 1.00, 0.15));
        }



        public double ParquetCalculation(double roomLenght, double roomWidth, double parquetLenght, double parquetWidth)
        {
            double roomArea = roomLenght * roomWidth * 1.15;
            double pieceOfParquetArea = parquetLenght * parquetWidth;
            double numberOfParquetPieces = roomArea / pieceOfParquetArea;
            numberOfParquetPieces = Math.Ceiling(numberOfParquetPieces);
            return (int)numberOfParquetPieces;
        }

    }
}