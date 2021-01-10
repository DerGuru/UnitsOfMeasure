using UnitsOfMeasure.Volumes;

namespace UnitsOfMeasure
{
    public class Volume : MultiplicationCompound<Volume, Area, Distance>
    {
        public Volume(Distance a, Distance b, Distance c) : this((a * b), c) { }
        public Volume(Area a, Distance d) : base(a, d) { }

        public static Area operator /(Volume v, Distance d) => new DivisionCompound<Area, Volume, Distance>(v, d);
    }

    public class Volume<DistanceType> : Volume where DistanceType : Distance, new()
    {
        public Volume() : base(new DistanceType(), new DistanceType(), new DistanceType()) { }
        public Volume(double a) : base(a * new DistanceType(), new DistanceType(), new DistanceType()) { }
        public Volume(double a, double b, double c) : base(a * new DistanceType(), b * new DistanceType(), c * new DistanceType()) { }
    }

    public class Volume<Distance1, Distance2, Distance3> : Volume where Distance1 : Distance, new() where Distance2 : Distance, new() where Distance3 : Distance, new()
    {
        public Volume() : base(new Distance1(), new Distance2(), new Distance3()) { }
        public Volume(double a, double b, double c) : base(a * new Distance1(), b * new Distance2(), c * new Distance3()) { }
    }
}
