using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class Foot : Distance
    {
        public static readonly BigDouble Inches = 12;

        public Foot() { }

        public Foot(double value) : base(value) { }

        public Foot(BigDouble value) : base(value) { }

        public override string Unit => "'";

        public override BigDouble FactorToBaseUnit { get; set; } = new Inch().FactorToBaseUnit * Inches;
    }
}
