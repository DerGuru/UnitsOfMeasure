using UnitsOfMeasure.AbstractBase;

namespace UnitsOfMeasure.Distances
{
    public class MicroMeters : Distance<MicroMeters>
    {
        public MicroMeters()
        {
        }

        public MicroMeters(double value) : base(value) { }
        public override string SiUnit => "μm";

        internal override double FactorToBaseUnit => 0.000001;
    }
}
