﻿using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Masses
{
    public class KiloGramm : Mass<KiloGramm>
    {
        public KiloGramm()
        {
        }

        public KiloGramm(double value) : base(value)
        {
        }

        public override string SiUnit => "kg";

        internal override double FactorToBaseUnit => 1000;
    }
}