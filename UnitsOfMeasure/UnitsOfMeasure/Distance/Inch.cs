namespace UnitsOfMeasure.Distances
{
    public class Inch : Distance
    {
        public Inch() { }

        public Inch(double value) : base(value) { }

        public override string SiUnit => "\"";

        internal override double FactorToBaseUnit => 0.0254;
    }
}
