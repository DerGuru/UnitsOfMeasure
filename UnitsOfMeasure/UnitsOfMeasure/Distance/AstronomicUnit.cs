using UnitsOfMeasure.AbstractBase;
namespace UnitsOfMeasure.Distances
{
    public class AstronomicUnit : Distance<AstronomicUnit>
    {
        public AstronomicUnit(){ }

        public AstronomicUnit(double value) : base(value) { }

        public override string SiUnit => "au";

        internal override double FactorToBaseUnit => 149597870700;
    }
}
