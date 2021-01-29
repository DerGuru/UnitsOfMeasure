using System.Numerics;
using UnitsOfMeasure.Frequencies;

namespace UnitsOfMeasure
{
    public class Time : UnitOfMeasure<Time>
    {
        public static Time SiUnit { get; } = new Times.Second();
        public Time() { }
        public Time(BigDouble value) : base(value) { }
        public static Frequency operator /(BigDouble n, Time t) => new Herz(n / t.FactorToBaseUnit);
    }
}
