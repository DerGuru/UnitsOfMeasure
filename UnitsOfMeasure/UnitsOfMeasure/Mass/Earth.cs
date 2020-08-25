﻿using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Masses
{
    public class Earth : Mass<Earth>
    {
        public Earth()
        {
        }

        public Earth(double value) : base(value)
        {
        }

        public override string SiUnit => "Earth(s)";

        internal override double FactorToBaseUnit => 5973600000000000000000000000.0;
    }
}