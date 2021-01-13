using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Linq;
using UnitsOfMeasure;

namespace UnitsOfMeasureTests
{
    public static class Extensions
    {
        public static void AreOne<T>(this UnitOfMeasure val, string unit) where T : UnitOfMeasure, new()
        {
            var m = new T() { Value = 1 };
            AreEqualTo(val, m, unit);

        }

        public static void AreEqualTo<T>(this UnitOfMeasure m, T o, string unit) where T : UnitOfMeasure
        {
            try
            {
                var t = m.GetType();

                Assert.AreEqual(o, m);
                Assert.AreEqual(m, o);
                var strings = new string[] {m.ToString(), o.ToString() };
                Assert.IsTrue(strings.Contains($"{m.Value} {unit}") || strings.Contains($"{o.Value} {unit}"));
                Assert.AreEqual(0, t.GetMethod("CompareTo").Invoke(m, new object[] { o }));
            }
            finally
            {
                Debug.WriteLine($"{m.ToString()} {m.FactorToBaseUnit } => {m.Value * m.FactorToBaseUnit}");
                Debug.WriteLine($"{o.ToString()} {o.FactorToBaseUnit } => {o.Value * o.FactorToBaseUnit}");
            }
        }
    }
}
