namespace UnitsOfMeasure.Distances
{
    public class NanoMeter : Distance
    {
        public NanoMeter()
        {
        }

        public NanoMeter(double value) : base(value) { }
        public override string SiUnit => "nm";

        internal override double FactorToBaseUnit => 0.000000001;
    }
}
