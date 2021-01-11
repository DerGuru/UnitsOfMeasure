namespace UnitsOfMeasure
{
    public class DivisionCompound<UnitT, CounterT, DenominatorT> : Compound<UnitT, CounterT, DenominatorT>
        where UnitT : UnitOfMeasure<UnitT> 
        where CounterT : UnitOfMeasure<CounterT> 
        where DenominatorT : UnitOfMeasure<DenominatorT>
    {
        protected DivisionCompound() { }
        public DivisionCompound(CounterT a, DenominatorT b) 
        {
            factorToBaseUnit = a.FactorToBaseUnit / b.FactorToBaseUnit;
            unit = $"({a.Unit}/{b.Unit})";
            Value = a.Value / b.Value;
        }

    }
}
