using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationTest
{
    [TestClass]
    public class ValidationTests
    {
        [TestMethod]
        public void IsValidHis()
        {
            Assert.AreEqual(true, Common.Validation.IsValidHIS("111 222 333"));
        }

        [DataTestMethod]
        [DataRow(true, "Ka", "Pál")]
        [DataRow(true, "Józsi", "Ka")]
        [DataRow(true, "Adolf", "Hitler")]
        [DataRow(true, "Zombori", "Pál")]
        [DataRow(true, "Kalányos", "Árpád")]
        [DataRow(false, "k", "p")]
        [DataRow(false, "K", "P")]
        [DataRow(false, "kA", "lApál")]
        [DataRow(false, "KaL", "Apál")]
        [DataRow(false, "Kal", "ApáL")]
        [DataRow(false, "Xae12", "Musk")]
        [DataRow(false, "JóZ5ik4","")]
        [DataRow(false, "","")]
        public void IsValidName(bool expected, string firstName, string lastName)
        {
            Assert.AreEqual(expected, Common.Validation.IsValidName(firstName, lastName));
        }
    } 
}
