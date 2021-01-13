using System.Numerics;

namespace UnitsOfMeasure.Frequencies
{
    public class KiloHerz : Frequency
    {
        public KiloHerz() { }
        public KiloHerz(BigDouble value) : base(value) { }
        public override string Unit { get; set; } = "kHz";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1, 3);
    }
}
