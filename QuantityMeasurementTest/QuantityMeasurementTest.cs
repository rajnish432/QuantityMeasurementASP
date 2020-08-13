using NUnit.Framework;

namespace QuantityMeasurementTest
{
    public class QuantityMeasurementTest
    {
        QuantityMeasurement.QuantityMeasurement quantityMeasurement;

        [SetUp]
        public void Setup()
        {
            quantityMeasurement = new QuantityMeasurement.QuantityMeasurement();
        }

        [Test]
        public void GivenTwoFeetSameValues_WhenCompared_ShouldReturnEqual()
        {
            double feet1 = quantityMeasurement.GetFeet(0.0);
            double feet2 = quantityMeasurement.GetFeet(0.0);
            Assert.AreEqual(feet1,feet2);
        }

        [Test]
        public void GivenTwoDifferentFeetValues_WhenCompared_ShouldReturnNotEqual()
        {
            double feet1 = quantityMeasurement.GetFeet(0.0);
            double feet2 = quantityMeasurement.GetFeet(10.0);
            Assert.AreNotEqual(feet1, feet2);
        }
    }
}