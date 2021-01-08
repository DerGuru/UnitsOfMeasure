namespace UnitsOfMeasure.Masses
{
    public class Moon : Mass
    {
        public Moon()
        {
        }

        public Moon(double value) : base(value)
        {
        }

        public override string SiUnit => "Moon(s)";

        internal override double FactorToBaseUnit => 73480000000000000000000000.0;
    }
}
