using System.Numerics;

namespace UnitsOfMeasure
{
    public abstract class Time : UnitOfMeasure<Time>
    {
        public Time() { }
        public Time(double value) : base(value) { }
        public Time(BigDouble value) : base(value) { }
    }
}
