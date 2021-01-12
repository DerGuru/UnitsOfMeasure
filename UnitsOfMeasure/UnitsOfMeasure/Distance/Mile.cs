using System.Numerics;

namespace UnitsOfMeasure.Distances
{
    public class Mile : Distance
    {
        public static readonly BigDouble Inches = 63360;
        public Mile() { }

        public Mile(double value) : base(value) { }

        public Mile(BigDouble value) : base(value) { }

        public override string Unit => "mi";

        public override BigDouble FactorToBaseUnit { get; set; } = new Inch().FactorToBaseUnit * Inches;
    }
}
