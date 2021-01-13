using System.Numerics;

namespace UnitsOfMeasure
{
    public class Velocity : UnitOfMeasure<Velocity>
    {
        public static Velocity SiUnit { get; } = new Velocities.MetersPerSecond();
        public Velocity() : base() { }
        protected Velocity(BigDouble value) : base(value) { }

        public static Distance operator *(Velocity v, Time t) => Multiply(v, t, new Distance());
        public static Distance operator *(Time t, Velocity v) => Multiply(v, t, new Distance());

        public static Frequency operator /(Velocity v, Distance t) => Divide(v, t, new Frequency());
        public static Time operator /(Distance d, Velocity v) => Divide(d, v, new Time());
    }
}
