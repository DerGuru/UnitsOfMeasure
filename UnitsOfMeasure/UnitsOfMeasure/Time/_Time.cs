

namespace UnitsOfMeasure
{
    public abstract class Time : UnitOfMeasure<Time>
    {
        protected Time() : this(1) { }
        protected Time(double value) : base(value) { }
    }
}
