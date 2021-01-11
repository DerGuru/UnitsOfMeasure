using System.Numerics;

namespace UnitsOfMeasure.Areas
{
    public class SquareCentiMeter : Area
    {
        public SquareCentiMeter() { }

        public SquareCentiMeter(double value) : base(value) { }

        public SquareCentiMeter(BigFloat value) : base(value) { }

        public override string Unit => "cm²";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(0.0001);

    }
}
