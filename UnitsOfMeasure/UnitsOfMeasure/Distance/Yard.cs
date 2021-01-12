using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class Yard : Distance
    {
        public static readonly BigDouble Inches = 36;
        public Yard() { }

        public Yard(double value) : base(value) { }

        public Yard(BigDouble value) : base(value) { }

        public override string Unit => "yd";

        public override BigDouble FactorToBaseUnit { get; set; } = new Inch().FactorToBaseUnit * Inches;
    }
}
