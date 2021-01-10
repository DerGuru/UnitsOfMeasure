using System;

namespace UnitsOfMeasure
{
    public class DivisionCompound<UnitT, CounterT, DenominatorT> : Compound<UnitT, CounterT, DenominatorT>
        where UnitT : UnitOfMeasure<UnitT> 
        where CounterT : UnitOfMeasure<CounterT> 
        where DenominatorT : UnitOfMeasure<DenominatorT>
    {
        public DivisionCompound(CounterT a, DenominatorT b) 
        {
            factorToBaseUnit = a.FactorToBaseUnit / b.FactorToBaseUnit;
            siUnit = $"({a.SiUnit}/{b.SiUnit})";
            Value = a.Value / b.Value;
        }

    }
}
