using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Volumes
{
    public class CubicKiloMeters : Volume<CubicKiloMeters>
    {
        public CubicKiloMeters()
        {
        }

        public CubicKiloMeters(double value) : base(value)
        {
        }

        public override string SiUnit => "km³";

        internal override double FactorToBaseUnit => 1000000000;
    }
}
