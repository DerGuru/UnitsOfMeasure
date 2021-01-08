using UnitsOfMeasure.AbstractBase;

namespace UnitsOfMeasure.Distances
{
    public class MicroMeter : Distance<MicroMeter>
    {
        public MicroMeter()
        {
        }

        public MicroMeter(double value) : base(value) { }
        public override string SiUnit => "μm";

        internal override double FactorToBaseUnit => 0.000001;
    }
}
