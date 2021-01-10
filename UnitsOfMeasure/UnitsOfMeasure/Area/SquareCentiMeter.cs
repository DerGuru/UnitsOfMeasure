using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareCentiMeter : Area
    {
        public SquareCentiMeter() : this (1)
        {
        }

        public SquareCentiMeter(double value) : base(value) { }

        public override string SiUnit => "cm²";

        internal override double FactorToBaseUnit { get; } = 0.0001;

    }
}
