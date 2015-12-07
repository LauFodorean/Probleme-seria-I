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

            Assert.AreEqual(8, ParquetCalculation(7.55, 0.15, 1.00, 0.15));
        }

        public double ParquetCalculation(double roomLenght, double roomWidth, double parquetLenght, double parquetWidth)
        {
            double roomArea = roomLenght * roomWidth;
            double pieceOfParquetArea = parquetLenght * parquetWidth;
            double numberOfParquetPieces = roomArea / pieceOfParquetArea;
            numberOfParquetPieces = Math.Ceiling(numberOfParquetPieces);
            return (int)numberOfParquetPieces;
        }

        //[TestMethod]
        //public void DimParchet()
        //{
            
        //    double Supraf = CalcSuprP(1.00, 0.25);
        //    Assert.AreEqual(1.00 * 0.25, Supraf);
        //}

        //public double CalcSuprP(double lungime, double latime)
        //{
        //    return lungime*latime;
        //}

        //[TestMethod]
        //public void NumarBucati()
        //{
            
        //    double BucatiParchet = BucParchet(5.45, 7.55, 1.00, 0.25);
        //    Assert.AreEqual(190, BucatiParchet);
        //}

        //public int BucParchet(double lungime, double latime, double lungimeP, double latimeP) //lungimeP si latimeP sunt dimensiunile bucatii de parchet
        //{
        //    double SuprafataNec = lungime * latime * 1.15;
        //    double dimensiune = lungimeP * latimeP;
        //    double nr1 = SuprafataNec / dimensiune;
        //    int bucatiparchet;
        //    int nr2 = Convert.ToInt32(nr1);
        //    double diferenta = nr1%nr2;
        //    if (diferenta>0)
        //        bucatiparchet=nr2+1;
        //    else
        //        bucatiparchet=nr2;
        //    return bucatiparchet;
        //}

     }
}
