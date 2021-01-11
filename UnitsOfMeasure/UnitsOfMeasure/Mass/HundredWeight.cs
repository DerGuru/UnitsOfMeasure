using System.Numerics;

namespace UnitsOfMeasure.Masses
{
    public class HundredWeight : Mass
    {
        public HundredWeight() { }

        public HundredWeight(double value) : base(value) { }

        public HundredWeight(BigFloat value) : base(value) { }

        public override string Unit => "cwt";

        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(50802.34544);
    }
}
