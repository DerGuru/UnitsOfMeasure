namespace UnitsOfMeasure.Distances
{
    public class AstronomicUnits : Distance<AstronomicUnits>
    {
        public AstronomicUnits(){ }

        public AstronomicUnits(double value) : base(value) { }

        public override string SiUnit => "au";

        protected override double FactorToBaseUnit => 149597870700;
    }
}
