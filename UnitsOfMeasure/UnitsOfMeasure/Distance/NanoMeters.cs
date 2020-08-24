namespace UnitsOfMeasure.Distances
{
    public class NanoMeters : Distance<NanoMeters>
    {
        public NanoMeters()
        {
        }

        public NanoMeters(double value) : base(value) { }
        public override string SiUnit => "nm";

        protected override double FactorToBaseUnit => 0.000000001 ;
    }
}
