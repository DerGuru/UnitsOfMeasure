namespace UnitsOfMeasure.Distances
{
    public class Yard : Distance<Yard>
    {
        public Yard() { }

        public Yard(double value) : base(value) { }

        public override string SiUnit => "yd";

        protected override double FactorToBaseUnit => 0.9144;
    }
}
