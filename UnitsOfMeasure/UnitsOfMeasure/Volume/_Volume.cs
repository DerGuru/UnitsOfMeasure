using System.Numerics;

namespace UnitsOfMeasure
{
    public abstract class Volume : UnitOfMeasure<Volume>
    {
        protected Volume() { }

        protected Volume(double value) : base(value) { }

        protected Volume(BigFloat value) : base(value) { }

        public static DivisionCompound<Area, Volume, Distance> operator /(Volume v, Distance d) => new DivisionCompound<Area, Volume, Distance>(v, d);
    }


}
