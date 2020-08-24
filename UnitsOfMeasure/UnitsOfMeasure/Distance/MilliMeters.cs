namespace UnitsOfMeasure.Distances
{
    public class MilliMeters : Distance<MilliMeters>
    {
        public MilliMeters()
        {
        }

        public MilliMeters(double value) : base(value){ }
        public override string SiUnit => "mm";

        protected override double FactorToBaseUnit => 0.001;
    }
}
