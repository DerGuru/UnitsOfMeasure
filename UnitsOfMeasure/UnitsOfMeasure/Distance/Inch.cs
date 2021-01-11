using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class Inch : Distance
    {
        public Inch() { }

        public Inch(double value) : base(value) { }

        public Inch(BigFloat value) : base(value) { }

        public override string Unit => "\"";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(254,10000);
    }
}
