using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class LunarDistance : Distance
    {
        public LunarDistance() { }

        public LunarDistance(double value) : base(value) { }

        public LunarDistance(BigDouble value) : base(value) { }

        public override string Unit => "ld";

        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(3842402, 3);
    }
}
