﻿using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Times
{
    public class LeapYear : Time<LeapYear>
    {
        public LeapYear()
        {
        }

        public LeapYear(double value) : base(value)
        {
        }
        public override string SiUnit => "y";
        internal override double FactorToBaseUnit => 31622400.0;
    }

}