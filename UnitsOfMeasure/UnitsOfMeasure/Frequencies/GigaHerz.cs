using System.Numerics;

namespace UnitsOfMeasure.Frequencies
{
    public class GigaHerz : Frequency
    {
        public GigaHerz() { }
        public GigaHerz(BigDouble value) : base(value) { }
        public override string Unit { get; set; } = "GHz";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1, 9);
    }
}
