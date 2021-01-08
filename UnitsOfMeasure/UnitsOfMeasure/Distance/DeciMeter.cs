namespace UnitsOfMeasure.Distances
{
    public class DeciMeter : Distance
    {
        public DeciMeter() { }

        public DeciMeter(double value) : base(value) { }
        public override string SiUnit => "dm";
        internal override double FactorToBaseUnit => 0.1;
    }
}
