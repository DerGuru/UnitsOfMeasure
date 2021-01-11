using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class DeciMeter : Distance
    {
        public DeciMeter() { }

        public DeciMeter(double value) : base(value) { }

        public DeciMeter(BigFloat value) : base(value) { }

        public override string Unit => "dm";
        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(1,10);
    }
}
