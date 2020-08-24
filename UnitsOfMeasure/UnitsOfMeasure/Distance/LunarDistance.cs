﻿namespace UnitsOfMeasure.Distances
{
    public class LunarDistance : Distance<LunarDistance>
    {
        public LunarDistance() {}

        public LunarDistance(double value) : base(value) { }

        public override string SiUnit => "ly";

        protected override double FactorToBaseUnit => 3842402000;
    }
}