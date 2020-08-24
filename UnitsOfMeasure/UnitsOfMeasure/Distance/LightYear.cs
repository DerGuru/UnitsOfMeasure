namespace UnitsOfMeasure.Distances
{
    public class LightYear : Distance<LightYear>
    {
        public LightYear() {}

        public LightYear(double value) : base(value) { }

        public override string SiUnit => "ly";

        protected override double FactorToBaseUnit => 9460730472580800;
    }
}
