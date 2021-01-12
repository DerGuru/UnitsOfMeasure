using System.Numerics;

namespace UnitsOfMeasure
{
    public class Volume : UnitOfMeasure<Volume>
    {
        internal Volume() { }

        public Volume(double value) : base(value) { }

        public Volume(BigDouble value) : base(value) { }

        public static Area operator /(Volume v, Distance d) => Divide(v, d, new Area());
        public static Distance operator /(Volume v, Area a) => Divide(v, a, new Distance());
    }
}
