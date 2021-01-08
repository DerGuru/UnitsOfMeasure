using System;

using UnitsOfMeasure.Areas;
using UnitsOfMeasure.Distances;

namespace UnitsOfMeasure
{
    public class Area : MultiplicationCompound<Area, Distance, Distance>
    {
        public Area(Distance v1, Distance v2) : base(v1,v2) { }

        public static Volume operator *(Area a, Distance d) => new Volume(a, d);
        public static Volume operator *(Distance d, Area a) => new Volume(a, d);

        public static Distance operator /(Area a, Distance d) => new DivisionCompound<Distance, Area, Distance>(a, d);

    }

    public class Area<DistanceType> : Area where DistanceType : Distance, new() 
    {
        public Area() : base(new DistanceType(),new DistanceType()) { }
        public Area(double a) : base(a * new DistanceType(), new DistanceType()) { }
        public Area(double a, double b) : base(a * new DistanceType(), b * new DistanceType()) { }
    }

    public class Area<Distance1, Distance2> : Area where Distance1 : Distance, new() where Distance2 : Distance, new()
    {
        public Area() : base(new Distance1(), new Distance2()) { }
        public Area(double a, double b) : base(a * new Distance1(), b * new Distance2()) { }
    }
}
