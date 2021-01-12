using System.Numerics;

namespace UnitsOfMeasure.Areas
{
    public class Hectar : Area
    {
        public Hectar() { }
        public Hectar(double value) : base(value) { }

        public Hectar(BigDouble value) : base(value) { }

        public override string Unit => "ha";

        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1,4);
    }

}
