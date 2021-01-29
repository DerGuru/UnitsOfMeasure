using System.Numerics;

namespace UnitsOfMeasure.Frequencies
{
    public class MegaHerz : Frequency
    {
        public MegaHerz() { }
        public MegaHerz(BigDouble value) : base(value) { }
        public override string Unit { get; set; } = "MHz";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1, 6);
    }
}
