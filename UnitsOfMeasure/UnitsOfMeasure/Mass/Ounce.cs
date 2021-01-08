namespace UnitsOfMeasure.Masses
{
    public class Ounce : Mass
    {
        public Ounce()
        {
        }

        public Ounce(double value) : base(value)
        {
        }

        public override string SiUnit => "oz";

        internal override double FactorToBaseUnit => 28.349523125;
    }
}
