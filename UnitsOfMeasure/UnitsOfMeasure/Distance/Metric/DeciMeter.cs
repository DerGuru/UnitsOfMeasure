using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class DeciMeter : Distance
    {
        public DeciMeter() { }
        public DeciMeter(BigDouble value) : base(value) { }
        public override string Unit => "dm";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1, -1);
    }
}
