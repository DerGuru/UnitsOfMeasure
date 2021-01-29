using System.Numerics;
using UnitsOfMeasure.Frequencies;

namespace UnitsOfMeasure
{
    public class Frequency : UnitOfMeasure<Frequency>
    {
        public static Frequency SiUnit { get; } = new Frequencies.Herz();
        public Frequency() { }
        public Frequency(BigDouble value) : base(value) { }

        public static BigDouble operator *(Frequency f, Time t) => f.SiValue * t.SiValue;
        public static BigDouble operator *(Time t, Frequency f) => f.SiValue * t.SiValue;
        public static Velocity operator *(Frequency f, Distance d) => Multiply(f, d, new Velocity());
        public static Velocity operator *( Distance d, Frequency f) => Multiply(f, d, new Velocity());
        public static Distance operator /(Velocity t, Frequency f) => Divide(t, f, new Distance());

    }
}
