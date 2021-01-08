namespace UnitsOfMeasure.Distances
{
    public class LunarDistance : Distance
    {
        public LunarDistance() {}

        public LunarDistance(double value) : base(value) { }

        public override string SiUnit => "ly";

        internal override double FactorToBaseUnit => 3842402000;
    }
}
