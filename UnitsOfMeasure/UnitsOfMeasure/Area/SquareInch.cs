
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure.Areas
{
    public class SquareInch : Area
    {
        public SquareInch() : this (1) { }

        public SquareInch(double value) : base(value)
        {
        }

        public override string SiUnit => "in²";

        internal override double FactorToBaseUnit { get; } = 0.00064516;
    }

}
