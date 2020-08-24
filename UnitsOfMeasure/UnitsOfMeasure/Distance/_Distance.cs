namespace UnitsOfMeasure
{
    public abstract class Distance : UnitOfMeasure<Distance>
    {
        protected Distance() { }
        protected Distance(double value) : base(value) { }
    }

    public abstract class Distance<T> : Distance where T : Distance<T>, new()
    {
        protected Distance() { }
        protected Distance(double value) : base(value) { }

        public override int CompareTo(Distance other) 
            => Value.CompareTo(other.ConvertTo<T>().Value);

        public override bool Equals(Distance other) 
            => Value.Equals(other.ConvertTo<T>().Value);

        public override UnitOfMeasure<Distance> Add(UnitOfMeasure<Distance> other)
            => new T { Value = Value + (other as Distance).ConvertTo<T>().Value };

        public override UnitOfMeasure<Distance> Subtract(UnitOfMeasure<Distance> other)
            => new T { Value = Value - (other as Distance).ConvertTo<T>().Value };
    }
}
