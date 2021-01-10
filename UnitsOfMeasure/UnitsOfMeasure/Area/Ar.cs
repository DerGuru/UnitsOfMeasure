using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class Ar : Area
    {
        public Ar() : this(1)
        {
        }

        public Ar(double value) : base(value)
        {
        }

        public override string SiUnit => "a";

        internal override double FactorToBaseUnit { get; } = 100;
    }

}
