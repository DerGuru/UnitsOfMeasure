namespace UnitsOfMeasure.Distances
{
    public class LightYear : Distance
    {
        public LightYear() {}

        public LightYear(double value) : base(value) { }

        public override string SiUnit => "ly";

        internal override double FactorToBaseUnit => 9460730472580800;
    }
}
