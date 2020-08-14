// <copyright file="QuantityMeasurementTest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace QuantityMeasurementTest
{
    using NUnit.Framework;
    using System;

    /// <summary>
    /// Class to Test QuantityMeasurement.
    /// </summary>
    public class QuantityMeasurementTest
    {
        /// <summary>
        /// Calling Main Class.
        /// </summary>
        private QuantityMeasurement.QuantityMeasurement quantityMeasurement;

        /// <summary>
        /// Setup Method.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            this.quantityMeasurement = new QuantityMeasurement.QuantityMeasurement();
        }

        /// <summary>
        /// Test 1.1: To Check 0 feet equals 0 feet.
        /// </summary>
        [Test]
        public void GivenTwoFeetSameValues_WhenCompared_ShouldReturnEqual()
        {
            double feetOne = this.quantityMeasurement.GetConvertedValue(0.0, QuantityMeasurement.ConversionUnits.Units.INCH_TO_FEET);
            double feetTwo = this.quantityMeasurement.GetConvertedValue(0.0, QuantityMeasurement.ConversionUnits.Units.INCH_TO_FEET);
            Assert.AreEqual(feetOne, feetTwo);
        }

        /// <summary>
        /// Test 1.1: To Check 10 feet is not equal to 0 feet.
        /// </summary>
        [Test]
        public void GivenTwoDifferentFeetValues_WhenCompared_ShouldReturnNotEqual()
        {
            double feetOne = this.quantityMeasurement.GetConvertedValue(0.0, QuantityMeasurement.ConversionUnits.Units.INCH_TO_FEET);
            double feetTwo = this.quantityMeasurement.GetConvertedValue(10.0, QuantityMeasurement.ConversionUnits.Units.INCH_TO_FEET);
            Assert.AreNotEqual(feetOne, feetTwo);
        }

        /// <summary>
        /// Test 1.2: To Check is Object is null.
        /// </summary>
        [Test]
        public void GivenNullFeetValues_WhenChecked_ShouldReturnFalse()
        {
            bool result = this.quantityMeasurement.Equals(null);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test 1.3: To Check is Object Reference.
        /// </summary>
        [Test]
        public void GivenClassReference_WhenChecked_ShouldReturnTrue()
        {
            bool result = this.quantityMeasurement.Equals(this.quantityMeasurement);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test 1.4: To Check Type.
        /// </summary>
        [Test]
        public void GivenClassReference_WhenTypeChecked_ShouldReturnTrue()
        {
            QuantityMeasurement.QuantityMeasurement quantity1 = new QuantityMeasurement.QuantityMeasurement();
            QuantityMeasurement.QuantityMeasurement quantity2 = new QuantityMeasurement.QuantityMeasurement();
            Assert.AreEqual(quantity1, quantity2);
        }

        /// <summary>
        /// Test 1.5: To Perform Equality Check.
        /// </summary>
        [Test]
        public void GivenTwoSameValues_WhenCompared_ShouldReturnEqual()
        {
            double feetOne = this.quantityMeasurement.GetConvertedValue(10.0, QuantityMeasurement.ConversionUnits.Units.INCH_TO_FEET);
            double feetTwo = this.quantityMeasurement.GetConvertedValue(10.0, QuantityMeasurement.ConversionUnits.Units.INCH_TO_FEET);
            Assert.AreEqual(feetOne, feetTwo);
        }

        /// <summary>
        /// Test 1.6: To Check 0 inch equals 0 inch.
        /// </summary>
        [Test]
        public void GivenTwoInchSameValues_WhenCompared_ShouldReturnEqual()
        {
            double inchOne = this.quantityMeasurement.GetConvertedValue(0.0, QuantityMeasurement.ConversionUnits.Units.FEET_TO_INCH);
            double inchTwo = this.quantityMeasurement.GetConvertedValue(0.0, QuantityMeasurement.ConversionUnits.Units.FEET_TO_INCH);
            Assert.AreEqual(inchOne, inchTwo);
        }

        /// <summary>
        /// Test 1.6: To Check 10 Inch is not equal to 0 Inch.
        /// </summary>
        [Test]
        public void GivenTwoDifferentInchValues_WhenCompared_ShouldReturnNotEqual()
        {
            double inchOne = this.quantityMeasurement.GetConvertedValue(0.0, QuantityMeasurement.ConversionUnits.Units.INCH_TO_FEET);
            double inchTwo = this.quantityMeasurement.GetConvertedValue(10.0, QuantityMeasurement.ConversionUnits.Units.INCH_TO_FEET);
            Assert.AreNotEqual(inchOne, inchTwo);
        }

        /// <summary>
        /// Test 1.7: To Check is Object is null.
        /// </summary>
        [Test]
        public void GivenNullValues_WhenChecked_ShouldReturnFalse()
        {
            bool result = this.quantityMeasurement.Equals(null);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test 1.8: To Check is Object Reference.
        /// </summary>
        [Test]
        public void GivenReference_WhenChecked_ShouldReturnTrue()
        {
            bool result = this.quantityMeasurement.Equals(this.quantityMeasurement);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test 1.9: To Check Type.
        /// </summary>
        [Test]
        public void GivenClassReferences_WhenTypeChecked_ShouldReturnTrue()
        {
            QuantityMeasurement.QuantityMeasurement quantity1 = new QuantityMeasurement.QuantityMeasurement();
            QuantityMeasurement.QuantityMeasurement quantity2 = new QuantityMeasurement.QuantityMeasurement();
            Assert.AreEqual(quantity1, quantity2);
        }

        /// <summary>
        /// Test 1.10: To Perform Equality Check.
        /// </summary>
        [Test]
        public void GivenTwoSameInchValues_WhenCompared_ShouldReturnEqual()
        {
            double inchOne = this.quantityMeasurement.GetConvertedValue(10.0, QuantityMeasurement.ConversionUnits.Units.FEET_TO_INCH);
            double inchTwo = this.quantityMeasurement.GetConvertedValue(10.0, QuantityMeasurement.ConversionUnits.Units.FEET_TO_INCH);
            Assert.AreEqual(inchOne, inchTwo);
        }

        /// <summary>
        /// Test 1.11: To Perform unit Conversion.
        /// </summary>
        [Test]
        public void GivenFeetValues_WhenProper_ShouldReturnInchValue()
        {
            double inchOne = this.quantityMeasurement.GetConvertedValue(0.0, QuantityMeasurement.ConversionUnits.Units.FEET_TO_INCH);
            Assert.AreEqual(0.0d, inchOne);
        }

        /// <summary>
        /// Test 1.12: To Check 1 Feet is Not Equal To 1 Inch.
        /// </summary>
        [Test]
        public void GivenFeetValue_WhenProper_ShouldReturnInchValue()
        {
            double inch = this.quantityMeasurement.GetConvertedValue(1.0, QuantityMeasurement.ConversionUnits.Units.FEET_TO_INCH);
            Assert.AreNotEqual(1.0, inch);
        }

        /// <summary>
        /// Test 1.13: To Check 1 Inch is Not Equal To 1 Feet.
        /// </summary>
        [Test]
        public void GivenInchValue_WhenProper_ShouldReturnFeetValue()
        {
            double feet = this.quantityMeasurement.GetConvertedValue(1.0, QuantityMeasurement.ConversionUnits.Units.INCH_TO_FEET);
            Assert.AreNotEqual(1.0, feet);
        }

        /// <summary>
        /// Test 1.14: To Check 1 Feet is Equal To 12 Inch.
        /// </summary>
        [Test]
        public void GivenFeetValue_WhenConverted_ShouldReturnInchValue()
        {
            double inch = this.quantityMeasurement.GetConvertedValue(1.0, QuantityMeasurement.ConversionUnits.Units.FEET_TO_INCH);
            Assert.AreEqual(12.0, inch);
        }

        /// <summary>
        /// Test 1.15: To Check 12 Inch is Equal To 1 Feet.
        /// </summary>
        [Test]
        public void GivenInchValue_WhenConverted_ShouldReturnFeetValue()
        {
            double feet = this.quantityMeasurement.GetConvertedValue(12.0, QuantityMeasurement.ConversionUnits.Units.INCH_TO_FEET);
            Assert.AreEqual(1.0, feet);
        }

        /// <summary>
        /// Test 2.1 To Check 3 Feet is Equal To 1 Yard.
        /// </summary>
        [Test]
        public void GivenFeeetValue_WhenConverted_ShouldReturnYardValue()
        {
            double yard = this.quantityMeasurement.GetConvertedValue(3.0, QuantityMeasurement.ConversionUnits.Units.FEET_TO_YARD);
            Assert.AreEqual(1.0, Math.Round(yard));
        }

        /// <summary>
        /// Test 2.2: To Check 1 Feet is Not Equal To 1 Yard.
        /// </summary>
        [Test]
        public void GivenFeeetValue_WhenConvertedToYard_ShouldReturnNotEqual()
        {
            double yard = this.quantityMeasurement.GetConvertedValue(1.0, QuantityMeasurement.ConversionUnits.Units.FEET_TO_YARD);
            Assert.AreNotEqual(1.0, Math.Round(yard));
        }

        /// <summary>
        /// Test 2.3: To Check 1 Inch is Not Equal To 1 Yard.
        /// </summary>
        [Test]
        public void GivenInchValue_WhenConvertedToYard_ShouldReturnNotEqual()
        {
            double yard = this.quantityMeasurement.GetConvertedValue(1.0, QuantityMeasurement.ConversionUnits.Units.INCH_TO_YARD);
            Assert.AreNotEqual(1.0, Math.Round(yard));
        }

        /// <summary>
        /// Test 2.4: To Check 1 Yard is Equal To 36 Inch.
        /// </summary>
        [Test]
        public void GivenYardValue_WhenConverted_ShouldReturnInchValue()
        {
            double inch = this.quantityMeasurement.GetConvertedValue(1.0, QuantityMeasurement.ConversionUnits.Units.YARD_TO_INCH);
            Assert.AreEqual(36.0, inch);
        }

        /// <summary>
        /// Test 2.5: To Check 36 Inch is Equal To 1 Yard.
        /// </summary>
        [Test]
        public void GivenInchValue_WhenConverted_ShouldReturnYardValue()
        {
            double yard = this.quantityMeasurement.GetConvertedValue(36.0, QuantityMeasurement.ConversionUnits.Units.INCH_TO_YARD);
            Assert.AreEqual(1.0, Math.Round(yard));
        }

        /// <summary>
        /// Test 2.6: To Check 1 Yard is Equal To 3 Feet.
        /// </summary>
        [Test]
        public void GivenYardValue_WhenConverted_ShouldReturnFeetValue()
        {
            double feet = this.quantityMeasurement.GetConvertedValue(1.0, QuantityMeasurement.ConversionUnits.Units.YARD_TO_FEET);
            Assert.AreEqual(3.0, feet);
        }

        /// <summary>
        /// Test 3.1: To Check 0 inch is Equal To 0 cm.
        /// </summary>
        [Test]
        public void GivenInchValue_WhenConvertedToCentimeter_ShouldReturnEqualValue()
        {
            double centimeter = this.quantityMeasurement.GetConvertedValue(0.0, QuantityMeasurement.ConversionUnits.Units.INCH_TO_CENTIMETER);
            Assert.AreEqual(0.0, centimeter);
        }

        /// <summary>
        /// Test 3.2: To Check 1 inch is Equal To 1 cm.
        /// </summary>
        [Test]
        public void GivenInchValue_WhenConvertedToCentimeter_ShouldReturnNotEqualValue()
        {
            double centimeter = this.quantityMeasurement.GetConvertedValue(1.0, QuantityMeasurement.ConversionUnits.Units.INCH_TO_CENTIMETER);
            Assert.AreNotEqual(1.0, centimeter);
        }

        /// <summary>
        /// Test 3.3: To Check 2 inch is Equal To 5 cm.
        /// </summary>
        [Test]
        public void GivenInchValue_WhenConverted_ShouldReturnCentimeterValue()
        {
            double centimeter = this.quantityMeasurement.GetConvertedValue(2.0, QuantityMeasurement.ConversionUnits.Units.INCH_TO_CENTIMETER);
            Assert.AreEqual(5.0, centimeter);
        }
    }
}