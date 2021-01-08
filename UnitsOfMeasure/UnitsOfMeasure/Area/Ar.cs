using UnitsOfMeasure.AbstractBase;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class Ar : Area<Meter>
    {
        public Ar() : this (1)
        {
        }

        public Ar(double value) : base(value * 100)
        {
        }

        public override string SiUnit => "a";

    }

}
