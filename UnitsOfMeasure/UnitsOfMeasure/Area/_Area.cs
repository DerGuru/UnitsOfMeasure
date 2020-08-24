namespace UnitsOfMeasure
{
    public abstract class Area : UnitOfMeasure<Area>
    {
        protected Area() { }
        protected Area(double value) : base(value) { }
    }

    public abstract class Area<T> : Area where T : Area<T>, new()
    {
        protected Area() { }
        protected Area(double value) : base(value) { }

        public override int CompareTo(Area other) => Value.CompareTo(other.ConvertTo<T>().Value);

        public override bool Equals(Area other) => Value.Equals(other.ConvertTo<T>().Value);

        public override UnitOfMeasure<Area> Add(UnitOfMeasure<Area> other)
            => new T { Value = Value + (other as Area).ConvertTo<T>().Value };

        public override UnitOfMeasure<Area> Subtract(UnitOfMeasure<Area> other)
            => new T { Value = Value - (other as Area).ConvertTo<T>().Value };
    }
}
