using System.Numerics;

namespace UnitsOfMeasure
{
    public class Volume : UnitOfMeasure<Volume>
    {
        public static Volume SiUnit { get; } = new Volumes.CubicMeter();
        public static Volume CreateCube(Distance d) => d * d * d;
        public static Volume CreateCuboid(Distance a, Distance b, Distance c) => a * b * c;
        public static Volume CreateSphere(Distance radius) => CreateCube(radius) * System.Math.PI * 4 / 3;
        
        public Volume() { }
        public Volume(BigDouble value) : base(value) { }

        public static Area operator /(Volume v, Distance d) => Divide(v, d, new Area());
        public static Distance operator /(Volume v, Area a) => Divide(v, a, new Distance());
    }
}
