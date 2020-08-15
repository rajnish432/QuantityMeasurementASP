// <copyright file="QuantityMeasurement.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace QuantityMeasurement
{
    using System;

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
        /// <param name="conversionUnit"></param>
        /// <returns></returns>
        public double GetConvertedValue(double[] unit, params ConversionUnits.Units[] conversionUnit)
        {
            double value = 0.0;
            for (int i = 0; i < unit.Length; i++)
            {
                if (conversionUnit[i].Equals(ConversionUnits.Units.CELCIUS_TO_FAHRENHEIT))
                {
                    Console.WriteLine("hello");
                    return (unit[i] * this.conversion.GetConversionUnit(conversionUnit[i])) + 32;
                }

                value += unit[i] * this.conversion.GetConversionUnit(conversionUnit[i]);
            }

            return value;
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
