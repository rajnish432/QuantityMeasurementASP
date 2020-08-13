// <copyright file="QuantityMeasurementTest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace QuantityMeasurementTest
{
    using NUnit.Framework;

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
            double feet1 = this.quantityMeasurement.GetConvertedValue(0.0);
            double feet2 = this.quantityMeasurement.GetConvertedValue(0.0);
            Assert.AreEqual(feet1, feet2);
        }

        /// <summary>
        /// Test 1.1: To Check 10 feet is not equal to 0 feet.
        /// </summary>
        [Test]
        public void GivenTwoDifferentFeetValues_WhenCompared_ShouldReturnNotEqual()
        {
            double feet1 = this.quantityMeasurement.GetConvertedValue(0.0);
            double feet2 = this.quantityMeasurement.GetConvertedValue(10.0);
            Assert.AreNotEqual(feet1, feet2);
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
            double feet1 = this.quantityMeasurement.GetConvertedValue(10.0);
            double feet2 = this.quantityMeasurement.GetConvertedValue(10.0);
            Assert.AreEqual(feet1, feet2);
        }

        /// <summary>
        /// Test 1.6: To Check 0 inch equals 0 inch.
        /// </summary>
        [Test]
        public void GivenTwoInchSameValues_WhenCompared_ShouldReturnEqual()
        {
            double inch1 = this.quantityMeasurement.GetConvertedValue(0.0);
            double inch2 = this.quantityMeasurement.GetConvertedValue(0.0);
            Assert.AreEqual(inch1, inch2);
        }

        /// <summary>
        /// Test 1.7: To Check 10 Inch is not equal to 0 Inch.
        /// </summary>
        [Test]
        public void GivenTwoDifferentInchValues_WhenCompared_ShouldReturnNotEqual()
        {
            double inch1 = this.quantityMeasurement.GetConvertedValue(0.0);
            double inch2 = this.quantityMeasurement.GetConvertedValue(10.0);
            Assert.AreNotEqual(inch1, inch2);
        }

        /// <summary>
        /// Test 1.8: To Check is Object is null.
        /// </summary>
        [Test]
        public void GivenNullValues_WhenChecked_ShouldReturnFalse()
        {
            bool result = this.quantityMeasurement.Equals(null);
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Test 1.9: To Check is Object Reference.
        /// </summary>
        [Test]
        public void GivenReference_WhenChecked_ShouldReturnTrue()
        {
            bool result = this.quantityMeasurement.Equals(this.quantityMeasurement);
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Test 1.10: To Check Type.
        /// </summary>
        [Test]
        public void GivenClassReferences_WhenTypeChecked_ShouldReturnTrue()
        {
            QuantityMeasurement.QuantityMeasurement quantity1 = new QuantityMeasurement.QuantityMeasurement();
            QuantityMeasurement.QuantityMeasurement quantity2 = new QuantityMeasurement.QuantityMeasurement();
            Assert.AreEqual(quantity1, quantity2);
        }

        /// <summary>
        /// Test 1.11: To Perform Equality Check.
        /// </summary>
        [Test]
        public void GivenTwoSameInchValues_WhenCompared_ShouldReturnEqual()
        {
            double inch1 = this.quantityMeasurement.GetConvertedValue(10.0);
            double inch2 = this.quantityMeasurement.GetConvertedValue(10.0);
            Assert.AreEqual(inch2, inch1);
        }
    }
}