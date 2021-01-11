using System.Numerics;

namespace UnitsOfMeasure
{
    public abstract class Area : UnitOfMeasure<Area>
    {
        protected Area() : base () { }
        protected Area(double value) : base(value) { }

        protected Area(BigFloat value) : base(value) { }

        public static MultiplicationCompound<Volume, Area, Distance> operator *(Area a, Distance d) => new MultiplicationCompound<Volume,Area,Distance>(a, d);
        public static MultiplicationCompound<Volume, Area, Distance> operator *(Distance d, Area a) => new MultiplicationCompound<Volume, Area, Distance>(a, d);

        public static UnitOfMeasure<Distance> operator /(Area a, Distance d) => new DivisionCompound<Distance, Area, Distance>(a, d).Convert(d);

    }
}
