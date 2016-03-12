using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MerchantGuide.Test.RomanNumeralValidatorTests
{
    [TestClass]
    public class IsValidNumeral_Should
    {
        [TestMethod]
        public void Return_True_For_Valid_Numerals()
        {
            Assert.IsTrue(RomanNumeralValidator.IsValidNumeral("I"));
            Assert.IsTrue(RomanNumeralValidator.IsValidNumeral("II"));
            Assert.IsTrue(RomanNumeralValidator.IsValidNumeral("IV"));
            Assert.IsTrue(RomanNumeralValidator.IsValidNumeral("MMVI"));
            Assert.IsTrue(RomanNumeralValidator.IsValidNumeral("MCMXLIV"));
            Assert.IsTrue(RomanNumeralValidator.IsValidNumeral("XXXIX"));
        }

        [TestMethod]
        public void Return_False_If_I_Is_Repeated_More_Than_Three_Times_In_Succession()
        {
            Assert.IsFalse(RomanNumeralValidator.IsValidNumeral("VIIII"));
        }

        [TestMethod]
        public void Return_False_If_X_Is_Repeated_More_Than_Three_Times_In_Succession()
        {
            Assert.IsFalse(RomanNumeralValidator.IsValidNumeral("CXXXX"));
        }

        [TestMethod]
        public void Return_False_If_C_Is_Repeated_More_Than_Three_Times_In_Succession()
        {
            Assert.IsFalse(RomanNumeralValidator.IsValidNumeral("MCCCC"));
        }

        [TestMethod]
        public void Return_False_If_M_Is_Repeated_More_Than_Three_Times_In_Succession()
        {
            Assert.IsFalse(RomanNumeralValidator.IsValidNumeral("MMMM"));
        }

        [TestMethod]
        public void Return_False_If_D_Is_Repeated()
        {
            Assert.IsFalse(RomanNumeralValidator.IsValidNumeral("DDC"));
        }

        [TestMethod]
        public void Return_False_If_L_Is_Repeated()
        {
            Assert.IsFalse(RomanNumeralValidator.IsValidNumeral("LLV"));
        }

        [TestMethod]
        public void Return_False_If_V_Is_Repeated()
        {
            Assert.IsFalse(RomanNumeralValidator.IsValidNumeral("VVI"));
        }

        [TestMethod]
        public void Return_False_If_I_Is_Subtracted_From_L()
        {
            Assert.IsFalse(RomanNumeralValidator.IsValidNumeral("IL"));
        }

        [TestMethod]
        public void Return_False_If_I_Is_Subtracted_From_C()
        {
            Assert.IsFalse(RomanNumeralValidator.IsValidNumeral("IC"));
        }

        [TestMethod]
        public void Return_False_If_I_Is_Subtracted_From_D()
        {
            Assert.IsFalse(RomanNumeralValidator.IsValidNumeral("ID"));
        }

        [TestMethod]
        public void Return_False_If_I_Is_Subtracted_From_M()
        {
            Assert.IsFalse(RomanNumeralValidator.IsValidNumeral("IM"));
        }

        [TestMethod]
        public void Return_False_If_X_Is_Subtracted_From_D()
        {
            Assert.IsFalse(RomanNumeralValidator.IsValidNumeral("XD"));
        }

        [TestMethod]
        public void Return_False_If_X_Is_Subtracted_From_M()
        {
            Assert.IsFalse(RomanNumeralValidator.IsValidNumeral("XM"));
        }

        [TestMethod]
        public void Return_False_If_V_Is_Subtracted_From_X()
        {
            Assert.IsFalse(RomanNumeralValidator.IsValidNumeral("VX"));
        }

        [TestMethod]
        public void Return_False_If_V_Is_Subtracted_From_L()
        {
            Assert.IsFalse(RomanNumeralValidator.IsValidNumeral("VL"));
        }

        [TestMethod]
        public void Return_False_If_V_Is_Subtracted_From_C()
        {
            Assert.IsFalse(RomanNumeralValidator.IsValidNumeral("VC"));
        }

        [TestMethod]
        public void Return_False_If_V_Is_Subtracted_From_D()
        {
            Assert.IsFalse(RomanNumeralValidator.IsValidNumeral("VD"));
        }

        [TestMethod]
        public void Return_False_If_V_Is_Subtracted_From_M()
        {
            Assert.IsFalse(RomanNumeralValidator.IsValidNumeral("VM"));
        }

        [TestMethod]
        public void Return_False_If_L_Is_Subtracted_From_C()
        {
            Assert.IsFalse(RomanNumeralValidator.IsValidNumeral("LC"));
        }

        [TestMethod]
        public void Return_False_If_L_Is_Subtracted_From_D()
        {
            Assert.IsFalse(RomanNumeralValidator.IsValidNumeral("LD"));
        }

        [TestMethod]
        public void Return_False_If_L_Is_Subtracted_From_M()
        {
            Assert.IsFalse(RomanNumeralValidator.IsValidNumeral("LM"));
        }

        [TestMethod]
        public void Return_False_If_D_Is_Subtracted_From_M()
        {
            Assert.IsFalse(RomanNumeralValidator.IsValidNumeral("DM"));
        }

        [TestMethod]
        public void Return_False_If_More_Than_One_I_Subtracted()
        {
            Assert.IsFalse(RomanNumeralValidator.IsValidNumeral("IIV"));
            Assert.IsFalse(RomanNumeralValidator.IsValidNumeral("IIX"));
        }

        [TestMethod]
        public void Return_False_If_More_Than_One_X_Subtracted()
        {
            Assert.IsFalse(RomanNumeralValidator.IsValidNumeral("XXL"));
            Assert.IsFalse(RomanNumeralValidator.IsValidNumeral("XXC"));
        }

        [TestMethod]
        public void Return_False_If_More_Than_One_C_Subtracted()
        {
            Assert.IsFalse(RomanNumeralValidator.IsValidNumeral("CCD"));
            Assert.IsFalse(RomanNumeralValidator.IsValidNumeral("CCM"));
        }
    }
}
