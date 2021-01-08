namespace UnitsOfMeasure.Masses
{
    public class MetricTon : Mass
    {
        public MetricTon()
        {
        }

        public MetricTon(double value) : base(value)
        {
        }

        public override string SiUnit => "t";

        internal override double FactorToBaseUnit => 1000000;
    }
}
