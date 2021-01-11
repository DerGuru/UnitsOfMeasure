using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class Foot : Distance
    {
        public Foot() { }

        public Foot(double value) : base(value) { }

        public Foot(BigFloat value) : base(value) { }

        public override string Unit => "'";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(3048,10000);
    }
}
