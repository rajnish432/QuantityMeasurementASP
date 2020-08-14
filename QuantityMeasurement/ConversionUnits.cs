﻿// <copyright file="ConversionUnits.cs" company="PlaceholderCompany">
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
            FEET_TO_INCH,
            INCH_TO_FEET,
            FEET_TO_YARD,
            INCH_TO_YARD,
            YARD_TO_INCH,
            YARD_TO_FEET,
            INCH_TO_CENTIMETER,
            INCH_TO_INCH,
            CENTIMETER_TO_INCH,
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
                case Units.INCH_TO_FEET:
                    return 1 / 12.0;

                case Units.FEET_TO_INCH:
                    return 1 * 12.0;

                case Units.FEET_TO_YARD:
                    return 0.33;

                case Units.INCH_TO_YARD:
                    return 1 / 36.0;

                case Units.YARD_TO_INCH:
                    return 36.0;

                case Units.YARD_TO_FEET:
                    return 3.0;

                case Units.INCH_TO_CENTIMETER:
                    return 2.5;

                case Units.CENTIMETER_TO_INCH:
                    return 1 / 2.5;

                default:
                    return 1.0;
            }
        }
    }
}
