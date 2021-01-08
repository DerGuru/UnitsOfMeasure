namespace UnitsOfMeasure.Masses
{
    public class Quarter : Mass
    {
        public Quarter()
        {
        }

        public Quarter(double value) : base(value)
        {
        }

        public override string SiUnit => "qu";

        internal override double FactorToBaseUnit => 12700.586360;
    }
}
