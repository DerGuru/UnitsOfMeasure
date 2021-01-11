using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class LeapYear : Time
    {
        public LeapYear() { }

        public LeapYear(double value) : base(value) { }

        public LeapYear(BigFloat value) : base(value) { }

        public override string Unit => "y";
        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(31622400.0);
    }

}
