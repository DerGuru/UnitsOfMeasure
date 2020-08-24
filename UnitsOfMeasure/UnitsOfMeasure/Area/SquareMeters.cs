namespace UnitsOfMeasure.Areas
{
    public class SquareMeters : Area<SquareMeters>
    {
        public SquareMeters()
        {
        }

        public SquareMeters(double value) : base(value)
        {
        }

        public override string SiUnit => "㎡";

        protected override double FactorToBaseUnit => 1;
    }
}
