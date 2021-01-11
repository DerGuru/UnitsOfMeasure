using System.Numerics;

namespace UnitsOfMeasure.Volumes
{
    public class OlympicSwimmingPool : Volume
    {
        public OlympicSwimmingPool() { }

        public OlympicSwimmingPool(double value) : base(value) { }

        public OlympicSwimmingPool(BigFloat value) : base(value) { }

        public override string Unit => "Olympic Swimming Pool(s)";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(2500);
    }
}
