// <copyright file="ConversionUnits.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace QuantityMeasurement
{
    /// <summary>
    /// Conversion Units Class.
    /// </summary>
    public class ConversionUnits
    {
        /// <summary>
        /// Conversions Units as enum.
        /// </summary>
        public enum Units
        {
            INCH,
            FEET,
        }

        /// <summary>
        /// Function to get Double Enum Values.
        /// </summary>
        /// <param name="units"></param>
        /// <returns></returns>
        public double GetConversionUnit(Units units)
        {
            switch (units)
            {
                case Units.FEET:
                    return 1 / 12.0;

                case Units.INCH:
                    return 1 * 12.0;

                default:
                    return 0.0;
            }
        }
    }
}
