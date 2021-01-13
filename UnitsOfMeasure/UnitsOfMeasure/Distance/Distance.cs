
using System.Numerics;

namespace UnitsOfMeasure
{
    public class Distance : UnitOfMeasure<Distance>
    {
        public static Distance SiUnit { get; } = new Distances.Meter();
        public Distance() { }
        public Distance(BigDouble value) : base(value) { }
        public static Velocity operator /(Distance d, Time t) =>  Divide(d, t, new Velocity());
        public static Area operator * (Distance a, Distance b) => Multiply(a, b, new Area());
    }
}
