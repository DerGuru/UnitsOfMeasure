using System.Numerics;

namespace UnitsOfMeasure.Volumes
{
    public class Liter : Volume
    {
        public Liter() { }

        public Liter(double value) : base(value) { }

        public Liter(BigFloat value) : base(value) { }

        public override string Unit => "l";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(0.001);
    }
}
