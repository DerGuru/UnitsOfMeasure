namespace UnitsOfMeasure.Distances
{
    public class Meter : Distance
    {
        public Meter() { }

        public Meter(double value) : base(value) { }

        public override string SiUnit => "m";

        internal override double FactorToBaseUnit => 1;
    }
}
