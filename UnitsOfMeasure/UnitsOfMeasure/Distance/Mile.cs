using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class Mile : Distance
    {
        public Mile() { }

        public Mile(double value) : base(value) { }

        public Mile(BigFloat value) : base(value) { }

        public override string Unit => "mi";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(16093472,10000);
    }
}
