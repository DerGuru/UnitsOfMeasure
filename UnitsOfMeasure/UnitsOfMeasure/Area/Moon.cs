﻿using UnitsOfMeasure.AbstractBase;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class Moon : Area<KiloMeter>
    {
        public Moon() : this(1)
        {
        }

        public Moon(double value) : base(value * 37932330)
        {
        }

        public override string SiUnit => "Moon(s)";

    }

}
