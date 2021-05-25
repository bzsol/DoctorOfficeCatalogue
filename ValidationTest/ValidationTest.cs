using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationTest
{
    [TestClass]
    public class ValidationTest
    {
        [DataTestMethod]
        [DataRow(true, "123 456 789")]
        [DataRow(true, "222 222 222")]
        [DataRow(true, "500 000 010")]
        [DataRow(true, "999 999 999")]
        [DataRow(true, "639 114 525")]
        public void Fill_WithValidHIS_HISAccepted(bool expected, string HIS)
        {
            // Arrange
            bool actual;

            // Act
            actual = Common.Validation.IsValidHIS(HIS);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(false, "44 555 777")]
        [DataRow(false, "444 55 777")]
        [DataRow(false, "444 555 77")]
        [DataRow(false, "444555777")]
        [DataRow(false, "444 555777")]
        [DataRow(false, "444 555 77k")]
        [DataRow(false, "-111 555 777")]
        [DataRow(false, "444 5555 777")]
        [DataRow(false, "444 0555 777")]
        [DataRow(false, "444 555  777")]
        public void Fill_WithValidHIS_HISDeclined(bool expected, string HIS)
        {
            // Arrange
            bool actual;

            // Act
            actual = Common.Validation.IsValidHIS(HIS);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(true, "Ka", "Pál")]
        [DataRow(true, "Józsi", "Ka")]
        [DataRow(true, "Kiss", "Bence")]
        [DataRow(true, "Tisza", "István")]
        [DataRow(true, "Nagy", "Gábor")]
        public void Fill_WithValidName_NameAccepted(bool expected, string firstName, string lastName)
        {
            // Arrange
            bool actual;

            // Act
            actual = Common.Validation.IsValidName(firstName, lastName);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(false, "", "")]
        [DataRow(false, "K", "Áron")]
        [DataRow(false, "Kiss", "Á")]
        [DataRow(false, "KiSs", "Áron")]
        [DataRow(false, "kiss", "Áron")]
        [DataRow(false, "Kiss", "áron")]
        [DataRow(false, "Kiss", "ÁroN")]
        [DataRow(false, "XAE12", "Musk")]
        [DataRow(false, "Xae12", "Musk")]
        [DataRow(false, "Kis s", "Áron")]
        public void Fill_WithUnvalidName_NameDeclined(bool expected, string firstName, string lastName)
        {
            // Arrange
            bool actual;

            // Act
            actual = Common.Validation.IsValidName(firstName, lastName);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}