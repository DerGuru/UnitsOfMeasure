using System.Numerics;

namespace UnitsOfMeasure
{
    public abstract class Mass : UnitOfMeasure<Mass>
    {
        protected Mass() { }
        protected Mass(double value) : base(value) { }

        protected Mass(BigFloat value) : base(value) { }
    }
}

