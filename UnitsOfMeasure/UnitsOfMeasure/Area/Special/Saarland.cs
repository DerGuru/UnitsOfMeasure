using System.Numerics;

namespace UnitsOfMeasure.Areas
{
    public class Saarland : Area
    {
        public Saarland() { }
        public Saarland(BigDouble value) : base(value) { }
        public override string Unit => "Saarland";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(257,7);
    }
}
