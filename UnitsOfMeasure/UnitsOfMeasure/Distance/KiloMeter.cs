namespace UnitsOfMeasure.Distances
{
    public class KiloMeter : Distance
    {
        public KiloMeter()
        {
        }

        public KiloMeter(double value) : base(value) { }
        public override string SiUnit => "km";

        internal override double FactorToBaseUnit => 1000;
    }
}
