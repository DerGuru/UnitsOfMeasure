using System.Numerics;

namespace UnitsOfMeasure.Areas
{
    public class SquareMeter : Area
    {
        public SquareMeter() { }

        public SquareMeter(double value) : base(value) { }

        public SquareMeter(BigDouble value) : base(value) { }

        public override string Unit => "m²";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1);

    }

}
