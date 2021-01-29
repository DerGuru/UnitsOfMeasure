using System.Numerics;

namespace UnitsOfMeasure.Frequencies
{
    public class NanoHerz : Frequency
    {
        public NanoHerz() { }
        public NanoHerz(BigDouble value) : base(value) { }
        public override string Unit { get; set; } = "nHz";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1, -9);
    }
}
