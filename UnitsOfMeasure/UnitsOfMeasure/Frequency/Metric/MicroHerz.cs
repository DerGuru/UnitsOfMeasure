using System.Numerics;

namespace UnitsOfMeasure.Frequencies
{
    public class MicroHerz : Frequency
    {
        public MicroHerz() { }
        public MicroHerz(BigDouble value) : base(value) { }
        public override string Unit { get; set; } = "μHz";
        public override BigDouble FactorToBaseUnit { get; set; } = new BigDouble(1, -6);
    }
}
