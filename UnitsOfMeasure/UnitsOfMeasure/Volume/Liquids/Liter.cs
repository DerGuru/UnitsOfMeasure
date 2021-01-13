using System.Numerics;

namespace UnitsOfMeasure.Volumes
{
    public class Liter : Volume
    {
        public Liter() { }
        public Liter(BigDouble value) : base(value) { }
        public override string Unit => "l";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1, -3);
    }
}
