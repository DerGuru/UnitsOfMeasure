namespace UnitsOfMeasure.Distances
{
    public class Inch : Distance<Inch>
    {
        public Inch() { }

        public Inch(double value) : base(value) { }

        public override string SiUnit => "\"";

        protected override double FactorToBaseUnit => 0.0254;
    }
}
