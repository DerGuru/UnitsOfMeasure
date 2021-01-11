using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class LunarDistance : Distance
    {
        public LunarDistance() { }

        public LunarDistance(double value) : base(value) { }

        public LunarDistance(BigFloat value) : base(value) { }

        public override string Unit => "ld";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(3842402000);
    }
}
