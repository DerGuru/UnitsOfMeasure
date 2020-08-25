using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Volumes
{
    public class CubicMicroMeters : Volume<CubicMicroMeters>
    {
        public CubicMicroMeters()
        {
        }

        public CubicMicroMeters(double value) : base(value)
        {
        }

        public override string SiUnit => "μm³";

        internal override double FactorToBaseUnit => 0.000000000000000001;
    }
}
