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
        /// <summary>
        /// Function to get double values.
        /// </summary>
        /// <param name="feet"></param>
        /// <returns></returns>
        public double GetFeet(double feet)
        {
            return feet;
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
