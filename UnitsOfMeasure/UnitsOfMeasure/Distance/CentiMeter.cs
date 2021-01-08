using UnitsOfMeasure.AbstractBase;

namespace UnitsOfMeasure.Distances
{
    public class CentiMeter : Distance<CentiMeter>
    {
        public CentiMeter() { }

        public CentiMeter(double value) : base(value) { }
        public override string SiUnit => "cm";
        internal override double FactorToBaseUnit => 0.01;
    }
}
