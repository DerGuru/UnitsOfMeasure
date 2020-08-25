using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Distances
{
    public class AstronomicUnits : Distance<AstronomicUnits>
    {
        public AstronomicUnits(){ }

        public AstronomicUnits(double value) : base(value) { }

        public override string SiUnit => "au";

        internal override double FactorToBaseUnit => 149597870700;
    }
}
