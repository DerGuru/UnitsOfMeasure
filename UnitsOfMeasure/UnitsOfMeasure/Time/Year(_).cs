﻿
namespace UnitsOfMeasure.Times
{
    public class Year : Time
    {
        public Year()
        {
        }

        public Year(double value) : base(value)
        {
        }

        public override string SiUnit => "y";

        internal override double FactorToBaseUnit => 31536000.0;
    }

}
