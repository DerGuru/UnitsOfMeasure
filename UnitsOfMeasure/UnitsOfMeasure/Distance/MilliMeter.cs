namespace UnitsOfMeasure.Distances
{
    public class MilliMeter : Distance
    {
        public MilliMeter()
        {
        }

        public MilliMeter(double value) : base(value){ }
        public override string SiUnit => "mm";

        internal override double FactorToBaseUnit => 0.001;
    }
}
