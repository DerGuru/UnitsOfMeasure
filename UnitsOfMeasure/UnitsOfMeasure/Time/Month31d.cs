using System.Numerics;

namespace UnitsOfMeasure.Times
{
    public class Month31d : Time
    {
        public Month31d() { }

        public Month31d(double value) : base(value) { }

        public Month31d(BigFloat value) : base(value) { }

        public override string Unit => "m";
        public override BigFloat FactorToBaseUnit { get; } = new BigFloat(2678400.0);
    }

}
