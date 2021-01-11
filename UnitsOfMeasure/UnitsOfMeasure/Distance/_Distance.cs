
using System.Numerics;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure
{
    public abstract class Distance : UnitOfMeasure<Distance>
    {
        protected Distance() { }
        protected Distance(double value) : base(value) { }
        protected Distance(BigFloat value) : base(value) { }

        public static DivisionCompound<Velocity, Distance, Time> operator /(Distance d, Time t) => new DivisionCompound<Velocity, Distance, Time>(d, t);
        public static MultiplicationCompound<Area, Distance, Distance> operator * (Distance a, Distance b) => new MultiplicationCompound<Area, Distance, Distance>(a, b);
    }
}
