using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using UnitsOfMeasure;

namespace UnitsOfMeasureTests
{
    public static class _Extensions
    {
        public static void AreOne<T>(this UnitOfMeasure val) where T: UnitOfMeasure, new()
        {
            var m = new T() { Value = 1 };
            AreEqualTo(val, m);
        }

        public static void AreEqualTo<T>(this UnitOfMeasure m, T other) where T: UnitOfMeasure
        {
            try { 
            var t = m.GetType();

            Assert.AreEqual(other, m);
            Assert.AreEqual(m, other);
            Assert.AreEqual(0, t.GetMethod("CompareTo").Invoke(m, new object[] { other }));
            }
            catch (Exception e)
            {
                Debug.WriteLine(m.Value);
                Debug.WriteLine(m.FactorToBaseUnit);
                Debug.WriteLine(other.Value);
                Debug.WriteLine(other.FactorToBaseUnit);
                Debug.WriteLine(m.Value * m.FactorToBaseUnit);
                Debug.WriteLine(other.Value * other.FactorToBaseUnit);
                throw;
            }
        }
    }
}
