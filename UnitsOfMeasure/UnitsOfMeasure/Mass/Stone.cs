namespace UnitsOfMeasure.Masses
{
    public class Stone : Mass
    {
        public Stone()
        {
        }

        public Stone(double value) : base(value)
        {
        }

        public override string SiUnit => "st";

        internal override double FactorToBaseUnit => 6350.293180;
    }
}
