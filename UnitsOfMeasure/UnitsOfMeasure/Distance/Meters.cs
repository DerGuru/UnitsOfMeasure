namespace UnitsOfMeasure.Distances
{
    public class Meters : Distance<Meters>
    {
        public Meters() { }

        public Meters(double value) : base(value) { }

        public override string SiUnit => "m";

        protected override double FactorToBaseUnit => 1;
    }
}
