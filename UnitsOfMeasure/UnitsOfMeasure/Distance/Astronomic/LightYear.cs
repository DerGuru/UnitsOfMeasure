using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class LightYear : Distance
    {
        public LightYear() { }
        public LightYear(BigDouble value) : base(value) { }
        public override string Unit => "ly";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(94607304725808, 2);
    }
}
