using System;
using System.Collections.Generic;
using System.Linq;
using Euler7;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEuler7 {
    [TestClass]
    public class UnitTest1 {

        [TestMethod]
        public void IsPrimeTrue() {
            bool ACTUAL = Euler7Main.IsPrime(13);
            Assert.IsTrue(ACTUAL);
        }

        [TestMethod]
        public void IsPrimeFalse() {
            bool ACTUAL = Euler7Main.IsPrime(9);
            Assert.IsFalse(ACTUAL);
        }

        [TestMethod]
        public void GetAllPrimesLowAmount() {
            int EXPECTED = 23;
            List<long> ACTUAL = Euler7Main.GetPrimes(10);
            Assert.AreEqual(EXPECTED, ACTUAL[9]);
        }

        [TestMethod]
        public void GetAllPrimesEulerExample() {
            int EXPECTED = 13;
            List<long> ACTUAL = Euler7Main.GetPrimes(6);
            Assert.AreEqual(EXPECTED, ACTUAL.Last());
        }

        [TestMethod]
        public void GetAllPrimesActualExcersize() {
            int EXPECTED = 104743;
            List<long> ACTUAL = Euler7Main.GetPrimes(10001);
            Assert.AreEqual(EXPECTED, ACTUAL.Last());
        }

        [TestMethod]
        public void GetAllPrimesVeryHigh() {
            int EXPECTED = 4999999;
            List<long> ACTUAL = Euler7Main.GetPrimes(348513);
            Assert.AreEqual(EXPECTED, ACTUAL.Last());
        }
    }
}
