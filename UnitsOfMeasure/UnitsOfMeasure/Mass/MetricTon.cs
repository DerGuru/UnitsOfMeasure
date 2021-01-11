using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class MetricTon : Mass
    {
        public MetricTon() { }

        public MetricTon(double value) : base(value) { }

        public MetricTon(BigFloat value) : base(value) { }

        public override string Unit => "t";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(1000000);
    }
}
