using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class CentiMeter : Distance
    {
        public CentiMeter() { }

        public CentiMeter(double value) : base(value) { }

        public CentiMeter(BigDouble value) : base(value) { }

        public override string Unit => "cm";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1, -2);
    }
}
