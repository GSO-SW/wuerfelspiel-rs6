﻿using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {

        [TestMethod]
        public void Wuerfel_KannErstelltWerden()
        {
            //arrange 


            //act 
            Wuerfel w = new Wuerfel();

            //assert
            Assert.IsNotNull(w);
        }

        [TestMethod]
        public void Wuerfel_WuerfeltZahlEinsBisSechs()
        {
            //Arrange
            Wuerfel w = new Wuerfel();

            //Act
            int ergebnis = w.Wuerfeln();

            //Assert
            Assert.IsTrue(ergebnis >= 1);
            Assert.IsTrue(ergebnis <= 6);

        }

        [TestMethod]
        public void Wuerfel_WuerfeltNichtBeiGesichertemZustand()
        {
            //Arrange
            Wuerfel w = new Wuerfel();

            //Act
            int ergebnis = w.Wuerfeln();
            w.Gesichert = true;
            int ergebnis2 = w.Wuerfeln();

            Assert.AreEqual(ergebnis, ergebnis2);

        }

        [TestMethod]
        public void Wuerfel_SollDreiMalWuerfeln()
        {
            //arrange
            Wuerfel w = new Wuerfel();

            //act 
            int wuerfeln = w.WuerfelDreiMal();

            //Assert 
            Assert.AreEqual(3, wuerfeln);
        }

        [TestMethod]
        public void Wuerfel_SetztAugenzahlUndGesichertZurücl()
        {
            //arrange
            Wuerfel w = new Wuerfel();
            int augenzahl = 6;
            bool gesichert = true;

            //act
            w.ResetWuerfel();

            //assert
            Assert.AreEqual(0, w.Augenzahl);
            Assert.IsFalse(w.Gesichert);
        }

    }
}
