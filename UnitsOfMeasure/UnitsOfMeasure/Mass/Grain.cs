﻿using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Masses
{
    public class Grain : Mass<Grain>
    {
        public Grain()
        {
        }

        public Grain(double value) : base(value)
        {
        }

        public override string SiUnit => "gr";

        internal override double FactorToBaseUnit => 0.06479891;
    }
}