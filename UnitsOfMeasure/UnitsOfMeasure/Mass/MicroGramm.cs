namespace UnitsOfMeasure.Masses
{
    public class MicroGramm : Mass
    {
        public MicroGramm()
        {
        }

        public MicroGramm(double value) : base(value)
        {
        }

        public override string SiUnit => "μg";

        internal override double FactorToBaseUnit => 0.000001;
    }
}
