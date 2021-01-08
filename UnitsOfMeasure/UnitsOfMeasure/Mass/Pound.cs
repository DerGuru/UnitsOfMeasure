namespace UnitsOfMeasure.Masses
{
    public class Pound : Mass
    {
        public Pound()
        {
        }

        public Pound(double value) : base(value)
        {
        }

        public override string SiUnit => "lb";

        internal override double FactorToBaseUnit => 453.59237;
    }
}
