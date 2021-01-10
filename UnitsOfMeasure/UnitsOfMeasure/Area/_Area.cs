
using UnitsOfMeasure.Areas;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure
{
    public abstract class Area : UnitOfMeasure<Area>
    {
       
        protected Area() : base () { }
        protected Area(double value) : base()
        {
            Value = value;
        }

        public static Volume operator *(Area a, Distance d) => new Volume(a, d);
        public static Volume operator *(Distance d, Area a) => new Volume(a, d);

        public static Distance operator /(Area a, Distance d) => new DivisionCompound<Distance, Area, Distance>(a, d).Convert(d);

    }
}
