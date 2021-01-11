using System.Numerics;

namespace UnitsOfMeasure
{
    public abstract class Time : UnitOfMeasure<Time>
    {
        protected Time() { }
        protected Time(double value) : base(value) { }
        protected Time(BigFloat value) : base(value) { }
    }
}
