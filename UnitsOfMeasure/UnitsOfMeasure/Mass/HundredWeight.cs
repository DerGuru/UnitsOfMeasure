﻿using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Masses
{
    public class HundredWeight : Mass<HundredWeight>
    {
        public HundredWeight()
        {
        }

        public HundredWeight(double value) : base(value)
        {
        }

        public override string SiUnit => "cwt";

        internal override double FactorToBaseUnit => 50802.34544;
    }
}
