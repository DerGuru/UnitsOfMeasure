using System.Numerics;

namespace UnitsOfMeasure.Areas
{
    public class SquareMicroMeter : Area
    {
        public SquareMicroMeter() { }

        public SquareMicroMeter(double value) : base(value) { }

        public SquareMicroMeter(BigFloat value) : base(value) { }

        public override string Unit => "μm²";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat( 1, 1000000000000);
    }

}
