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
            double feet1 = this.quantityMeasurement.GetFeet(0.0);
            double feet2 = this.quantityMeasurement.GetFeet(0.0);
            Assert.AreEqual(feet1, feet2);
        }

        /// <summary>
        /// Test 1.1: To Check 10 feet is not equal to 0 feet.
        /// </summary>
        [Test]
        public void GivenTwoDifferentFeetValues_WhenCompared_ShouldReturnNotEqual()
        {
            double feet1 = this.quantityMeasurement.GetFeet(0.0);
            double feet2 = this.quantityMeasurement.GetFeet(10.0);
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
    }
}