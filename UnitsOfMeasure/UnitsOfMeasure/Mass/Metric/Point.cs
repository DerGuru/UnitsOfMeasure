using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class Point : Mass
    {
        public Point() { }

        public Point(BigDouble value) : base(value) { }

        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1) / new BigDouble(500);

        public override string Unit => "pt";
    }
}
