namespace UnitsOfMeasure.Masses
{
    public class NanoGramm : Mass
    {
        public NanoGramm()
        {
        }

        public NanoGramm(double value) : base(value)
        {
        }

        public override string SiUnit => "ng";

        internal override double FactorToBaseUnit => 0.000000001;
    }
}
