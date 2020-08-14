// <copyright file="QuantityMeasurement.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace QuantityMeasurement
{
    /// <summary>
    /// Main Class To Perform Conversion.
    /// </summary>
    public class QuantityMeasurement
    {
        private ConversionUnits conversion = new ConversionUnits();
        /// <summary>
        /// Function to get converted values.
        /// </summary>
        /// <param name="unit"></param>
        /// <returns></returns>
        public double GetConvertedValue(double unit, ConversionUnits.Units conversionUnit)
        {
            return unit * this.conversion.GetConversionUnit(conversionUnit);
        }

        /// <summary>
        /// Overrriding Equals Method.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            if (obj is QuantityMeasurement)
            {
                return true;
            }

            return true;
        }

        /// <summary>
        /// Overriding GetHashCode Method.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
