using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class CentiMeter : Distance
    {
        public CentiMeter() { }

        public CentiMeter(double value) : base(value) { }

        public CentiMeter(BigFloat value) : base(value) { }

        public override string Unit => "cm";
        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(1,100);
    }
}
