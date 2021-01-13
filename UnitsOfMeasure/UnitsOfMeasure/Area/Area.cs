using System.Numerics;

namespace UnitsOfMeasure
{
    public class Area : UnitOfMeasure<Area>
    {
        public static Area SiUnit { get; } = new Areas.SquareMeter();
        public static Area CreateSquare(Distance d) => d * d;
        public static Area CreateRectangle(Distance a, Distance b) => a * b;
        public static Area CreateCircle(Distance radius) => CreateSquare(radius) * System.Math.PI;

        public Area() : base () { }
        public Area(BigDouble value) : base(value) { }

        public static Volume operator *(Area a, Distance d) => Multiply(a, d, new Volume());
        public static Volume operator *(Distance d, Area a) => Multiply(a, d, new Volume());

        public static Distance operator /(Area a, Distance d) => Divide(a, d, new Distance());

    }
}
