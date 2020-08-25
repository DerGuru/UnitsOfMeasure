using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Distances
{
    public class KiloMeters : Distance<KiloMeters>
    {
        public KiloMeters()
        {
        }

        public KiloMeters(double value) : base(value) { }
        public override string SiUnit => "km";

        internal override double FactorToBaseUnit => 1000;
    }
}
