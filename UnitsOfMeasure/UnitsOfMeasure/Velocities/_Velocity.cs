using System.Numerics;

namespace UnitsOfMeasure
{
    public abstract class Velocity : UnitOfMeasure<Velocity>
    {
        protected Velocity() { }

        protected Velocity(double value) : base(value){}

        protected Velocity(BigFloat value) : base(value){}

        public static MultiplicationCompound<Distance, Velocity, Time> operator *(Velocity v, Time t) => new MultiplicationCompound<Distance, Velocity, Time>(v, t);
        public static MultiplicationCompound<Distance, Velocity, Time> operator *(Time t, Velocity v) => new MultiplicationCompound<Distance, Velocity, Time>(v, t);
    }

    public class Velocity<DistanceType, TimeType> : DivisionCompound<Velocity,Distance, Time> where DistanceType : Distance where TimeType : Time
    {
        public Velocity(Distance d, Time t) : base (d, t){}
    }
}
