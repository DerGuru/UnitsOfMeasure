namespace UnitsOfMeasure.Distances
{
    public class CentiMeters : Distance<CentiMeters>
    {
        public CentiMeters() { }

        public CentiMeters(double value) : base(value) { }
        public override string SiUnit => "cm";
        protected override double FactorToBaseUnit => 0.01;
    }
}
