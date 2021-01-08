using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Distances
{
    public class KiloMeter : Distance<KiloMeter>
    {
        public KiloMeter()
        {
        }

        public KiloMeter(double value) : base(value) { }
        public override string SiUnit => "km";

        internal override double FactorToBaseUnit => 1000;
    }
}
