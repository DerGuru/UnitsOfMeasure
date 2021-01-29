using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace BigDoubleTests
{
    [TestClass]
    public class Tests
    {

        [TestMethod]
        public void _doubleTest()
        {
            double d = 123456788;
            Assert.AreEqual(123456788, d);
           
            Console.WriteLine(DoubleConverter.ToExactString(d));
            d /= 1e8;
            Assert.AreEqual(1.23456788, d);
            Console.WriteLine(DoubleConverter.ToExactString(d));
            d *= 1e8;
            Console.WriteLine(DoubleConverter.ToExactString(d));
            Assert.AreEqual(123456788, d);
        }

        public static BigDouble TestValueExponent4 = BigDouble.Parse("1.23456789e1234");
        public static BigDouble TestValueExponent1 = BigDouble.Parse("1.234567893e3");

        [TestMethod]
        public void TestToString()
        {
            Assert.AreEqual(TestValueExponent4.ToString(), "1.23456789E+1234");
        }

        [TestMethod]
        public void TestToExponential()
        {
            Assert.AreEqual(TestValueExponent4.ToString("E0"), "1E+1234");
            Assert.AreEqual(TestValueExponent4.ToString("E4"), "1.2346E+1234");
            Assert.AreEqual(TestValueExponent1.ToString("E0"), "1E+3");
            Assert.AreEqual(TestValueExponent1.ToString("E4"), "1.2346E+3");
        }

        [TestMethod]
        public void TestToFixed()
        {
            var aLotOfZeroes = new StringBuilder(1226)
                .Insert(0, "0", 1226)
                .ToString();
            Assert.AreEqual(TestValueExponent4.ToString("F0"), "123456789" + aLotOfZeroes);
            Assert.AreEqual(TestValueExponent4.ToString("F4"), "123456789" + aLotOfZeroes + ".0000");
            Assert.AreEqual(TestValueExponent1.ToString("F0"), "1235");
            Assert.AreEqual(TestValueExponent1.ToString("F4"), "1234.5679");
        }

        [TestMethod]
        public void TestEquals()
        {
            var value1 = new BigDouble(123, 5);
            var value2 = new BigDouble(1.23, 7);
            Assert.IsTrue(value1.Equals(value2));
        }

        [TestMethod]
        public void TestPow()
        {
            var result = BigDouble.Pow(1.15f, 6000);
            Assert.IsFalse(BigDouble.IsInfinity(result));
        }
    
    
        [TestMethod]
        public void SpecialValuesEquality()
        {
            Assert.IsTrue(BigDouble.PositiveInfinity.Equals(double.PositiveInfinity));
            Assert.IsTrue(BigDouble.NegativeInfinity.Equals(double.NegativeInfinity));
        }

        [TestMethod]
        public void Add()
        {
            foreach (BinaryTestCase testCase in FundamentalBinaryTestCases().Concat(GeneralBinaryTestCases()))
                testCase.AssertEqual((d1, d2) => d1 + d2, (bd1, bd2) => bd1 + bd2);
        }

        [TestMethod]
        public void Subtract()
        {
            foreach (BinaryTestCase testCase in FundamentalBinaryTestCases().Concat(GeneralBinaryTestCases()))
                testCase.AssertEqual((d1, d2) => d1 - d2, (bd1, bd2) => bd1 - bd2);
        }

        [TestMethod]
        public void Multiply()
        {
            foreach (BinaryTestCase testCase in FundamentalBinaryTestCases().Concat(GeneralBinaryTestCases()))
                testCase.AssertEqual((d1, d2) => d1 * d2, (bd1, bd2) => bd1 * bd2);
        }

        [TestMethod]
        public void Divide()
        {
            foreach (BinaryTestCase testCase in FundamentalBinaryTestCases().Concat(GeneralBinaryTestCases()))
                testCase.AssertEqual((d1, d2) => d1 / d2, (bd1, bd2) => bd1 / bd2);
        }

        [TestMethod]
        public void Negate()
        {
            foreach (UnaryTestCase testCase in FundamentalUnaryTestCases().Concat(GeneralUnaryTestCases()))
                testCase.AssertEqual(d => -d, bd => -bd);
        }

        [TestMethod]
        public void Equality()
        {
            foreach (BinaryTestCase testCase in FundamentalBinaryTestCases().Concat(GeneralBinaryTestCases()))
                testCase.AssertComparison((d1, d2) => d1 == d2, (bd1, bd2) => bd1 == bd2);
        }

        [TestMethod]
        public void Inequality()
        {
            foreach (BinaryTestCase testCase in FundamentalBinaryTestCases().Concat(GeneralBinaryTestCases()))
                testCase.AssertComparison((d1, d2) => d1 != d2, (bd1, bd2) => bd1 != bd2);
        }

        [TestMethod]
        public void GreaterThan()
        {
            foreach (BinaryTestCase testCase in FundamentalBinaryTestCases().Concat(GeneralBinaryTestCases()))
                testCase.AssertComparison((d1, d2) => d1 > d2, (bd1, bd2) => bd1 > bd2);
        }

        [TestMethod]
        public void GreaterThanOrEqual()
        {
            foreach (BinaryTestCase testCase in FundamentalBinaryTestCases().Concat(GeneralBinaryTestCases()))
                testCase.AssertComparison((d1, d2) => d1 >= d2, (bd1, bd2) => bd1 >= bd2);
        }

        [TestMethod]
        public void LessThan()
        {
            foreach (BinaryTestCase testCase in FundamentalBinaryTestCases().Concat(GeneralBinaryTestCases()))
                testCase.AssertComparison((d1, d2) => d1 < d2, (bd1, bd2) => bd1 < bd2);
        }

        [TestMethod]
        public void LessThanOrEqual()
        {
            foreach (BinaryTestCase testCase in FundamentalBinaryTestCases().Concat(GeneralBinaryTestCases()))
                testCase.AssertComparison((d1, d2) => d1 <= d2, (bd1, bd2) => bd1 <= bd2);
        }

        [TestMethod]
        
        public void CompareTo()
        {
            foreach (BinaryTestCase testCase in FundamentalBinaryTestCases().Concat(GeneralBinaryTestCases()))

                testCase.AssertEqual((d1, d2) => d1.CompareTo(d2), (bd1, bd2) => bd1.CompareTo(bd2));
        }

        [TestMethod]
       
        public void Log()
        {
            foreach (BinaryTestCase testCase in FundamentalBinaryTestCases().Concat(GeneralBinaryTestCases()))
                testCase.AssertEqual(Math.Log, (bd1, bd2) => BigDouble.Log(bd1, bd2));
        }

        [TestMethod]
        public void Pow()
        {
            foreach (BinaryTestCase testCase in GeneralBinaryTestCases())
                testCase.AssertEqual(Math.Pow, BigDouble.Pow);
        }

        [TestMethod]
        public void Abs()
        {
            foreach (UnaryTestCase testCase in FundamentalUnaryTestCases().Concat(GeneralUnaryTestCases()))
                testCase.AssertEqual(Math.Abs, BigDouble.Abs);
        }

        [TestMethod]
        public void Ceiling()
        {
            foreach (UnaryTestCase testCase in FundamentalUnaryTestCases().Concat(GeneralUnaryTestCases()))
                testCase.AssertEqual(Math.Ceiling, BigDouble.Ceiling);
        }

        [TestMethod]
       
        
        public void Cosh()
        {
            foreach (UnaryTestCase testCase in FundamentalUnaryTestCases().Concat(GeneralUnaryTestCases()))
                testCase.AssertEqual(Math.Cosh, BigDouble.Cosh, 1E-13);
        }

        [TestMethod]
       
        
        public void Exp()
        {
            foreach (UnaryTestCase testCase in FundamentalUnaryTestCases().Concat(GeneralUnaryTestCases()))
                testCase.AssertEqual(Math.Exp, BigDouble.Exp, 1E-13);
        }

        [TestMethod]
       
        
        public void Floor()
        {
            foreach (UnaryTestCase testCase in FundamentalUnaryTestCases().Concat(GeneralUnaryTestCases()))
                testCase.AssertEqual(Math.Floor, BigDouble.Floor);
        }

        [TestMethod]
       
        
        public void Log10()
        {
            foreach (UnaryTestCase testCase in FundamentalUnaryTestCases().Concat(GeneralUnaryTestCases()))
                testCase.AssertEqual(Math.Log10, d => BigDouble.Log10(d));
        }

        [TestMethod]
        
        public void Max()
        {
            foreach (BinaryTestCase testCase in FundamentalBinaryTestCases().Concat(GeneralBinaryTestCases()))
                testCase.AssertEqual(Math.Max, BigDouble.Max);
        }

        [TestMethod]
      
        public void Min()
        {
            foreach (BinaryTestCase testCase in FundamentalBinaryTestCases().Concat(GeneralBinaryTestCases()))
                testCase.AssertEqual(Math.Min, BigDouble.Min);
        }

        [TestMethod]
       
        
        public void Round()
        {
            foreach (UnaryTestCase testCase in FundamentalUnaryTestCases().Concat(GeneralUnaryTestCases()))
                testCase.AssertEqual(Math.Round, BigDouble.Round);
        }

        [TestMethod]


        public void Sign()
        {
            foreach (UnaryTestCase testCase in FundamentalUnaryTestCases().Concat(GeneralUnaryTestCases()))
            {
                if (double.IsNaN(testCase.Values.Double))
                {
                    Exception doubleException;
                    Exception bigDoubleException;
                    try
                    {
                        Math.Sign(testCase.Values.Double);
                        doubleException = new Exception();
                    }
                    catch (Exception e)
                    {
                        doubleException = e;
                    }
                    try
                    {
                        BigDouble.Sign(testCase.Values.BigDouble);
                        bigDoubleException = new Exception();
                    }
                    catch (Exception e)
                    {
                        bigDoubleException = e;
                    }
                    Assert.AreEqual(doubleException.GetType(), bigDoubleException.GetType());
                    return;
                }
                testCase.AssertEqual(d => Math.Sign(d), d => BigDouble.Sign(d));
            }
        }
        [TestMethod]
       
        
        public void Sinh()
        {
            foreach (UnaryTestCase testCase in FundamentalUnaryTestCases().Concat(GeneralUnaryTestCases()))
                testCase.AssertEqual(Math.Sinh, BigDouble.Sinh, 1E-13);
        }

        [TestMethod]
       
        
        public void Tanh()
        {
            foreach (UnaryTestCase testCase in FundamentalUnaryTestCases().Concat(GeneralUnaryTestCases()))
                testCase.AssertEqual(Math.Tanh, BigDouble.Tanh, 1E-13);
        }

        [TestMethod]
       
        
        public void Truncate()
        {
            foreach (UnaryTestCase testCase in FundamentalUnaryTestCases().Concat(GeneralUnaryTestCases()))
                testCase.AssertEqual(Math.Truncate, BigDouble.Truncate);
        }

        private static IEnumerable<UnaryTestCase> GeneralUnaryTestCases()
        {
            return GeneralTestCaseCombinator.UnaryTestCases;
        }

        private static IEnumerable<UnaryTestCase> FundamentalUnaryTestCases()
        {
            return FundamentalTestCaseCombinator.UnaryTestCases;
        }

        private static IEnumerable<BinaryTestCase> GeneralBinaryTestCases()
        {
            return GeneralTestCaseCombinator.BinaryTestCases;
        }

        private static IEnumerable<BinaryTestCase> FundamentalBinaryTestCases()
        {
            return FundamentalTestCaseCombinator.BinaryTestCases;
        }

        private static readonly TestCaseCombinator GeneralTestCaseCombinator = new TestCaseCombinator()
            .Value("0", 0)
            .Value("Integer", 345)
            .Value("Negative integer", -745)
            .Value("Big integer", 123456788)
            .Value("Big negative integer", -987654321)
            .Value("Small integer", 4)
            .Value("Small negative integer", -5)
            .Value("Big value", 3.7e63)
            .Value("Big negative value", -7.3e36)
            .Value("Really big value", 7.23e222)
            .Value("Really big negative value", -2.23e201)
            .Value("Small value", 5.323e-47)
            .Value("Small negative value", -8.252e-21)
            .Value("Really small value", 1.98e-241)
            .Value("Really small negative value", -6.79e-215);

        private static readonly TestCaseCombinator FundamentalTestCaseCombinator = new TestCaseCombinator()
            .Value("0", 0)
            .Value("1", 1)
            .Value("-1", -1)
            .Value("1,1", 1.1)
            .Value("-1,1", -1.1)
            .Value("0,9", 0.9)
            .Value("-0,9", -0.9)
            .Value("∞", double.PositiveInfinity)
            .Value("-∞", double.NegativeInfinity)
            .Value("NaN", double.NaN);

        private class TestCaseCombinator
        {
            private readonly List<TestCaseValue> values = new List<TestCaseValue>();

            public TestCaseCombinator Value(string name, double value)
            {
                values.Add(new TestCaseValue(name, value, BigDouble.Tolerance));
                return this;
            }

            public IEnumerable<UnaryTestCase> UnaryTestCases
            {
                get
                {
                    return values
                        .Select(v => new UnaryTestCase(v.Name, v.Value, v.Precision));
                }
            }

            public IEnumerable<BinaryTestCase> BinaryTestCases
            {
                get
                {
                    var current = 0;
                    while (current < values.Count)
                    {
                        for (var i = current; i < values.Count; i++)
                        {
                            foreach (var testCaseData in Permutate(values[current], values[i]))
                            {
                                yield return testCaseData;
                            }
                        }

                        current++;
                    }
                }
            }

            private static IEnumerable<BinaryTestCase> Permutate(TestCaseValue first, TestCaseValue second)
            {
                yield return TestCaseData(first, second);
                if (first != second)
                {
                    yield return TestCaseData(second, first);
                }
            }

            private static BinaryTestCase TestCaseData(TestCaseValue first, TestCaseValue second)
            {
                var testCase = new BinaryTestCase(first.Name, first.Value, second.Value, Math.Max(first.Precision, second.Precision));
                return testCase;
            }

            private class TestCaseValue
            {
                public string Name { get; }
                public double Value { get; }
                public double Precision { get; }

                public TestCaseValue(string name, double value, double precision)
                {
                    Name = name;
                    Value = value;
                    Precision = precision;
                }
            }
        }

        public static void AssertEqual(BigDouble bigDouble, double @double, double precision, string name)
        {
            if (IsOutsideDoubleRange(bigDouble))
            {
                Console.WriteLine("Result is not in range of possible Double values");
                return;
            }

            if (BigDouble.IsNaN(bigDouble) && double.IsNaN(@double))
            {
                return;
            }
            try
            {
                Assert.AreEqual(@double, bigDouble, $"Double implementation: {@double}, BigDouble implementation {bigDouble}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{name}:\t {e.Message}");
            }
        }

        private static bool IsOutsideDoubleRange(BigDouble bigDouble)
        {
            if (BigDouble.IsNaN(bigDouble) || BigDouble.IsInfinity(bigDouble))
            {
                return false;
            }

            return bigDouble.Exponent > Math.Log10(double.MaxValue)
                   || bigDouble.Exponent < Math.Log10(double.Epsilon);
        }

        public class UnaryTestCase
        {
            private readonly double @double;
            private readonly BigDouble bigDouble;
            private readonly double precision;
            private readonly string name;
            public UnaryTestCase(string name, double @double, double precision = 1e-13)
            {
                this.name = name;
                this.@double = @double;
                bigDouble = @double;
                this.precision = precision;
            }

            public (double Double, BigDouble BigDouble) Values => (@double, bigDouble);

            public void AssertEqual(Func<double, double> doubleOperation,
                Func<BigDouble, BigDouble> bigDoubleOperation)
            {
                AssertEqual( doubleOperation, bigDoubleOperation, precision);
            }

            public void AssertEqual(Func<double, double> doubleOperation,
                Func<BigDouble, BigDouble> bigDoubleOperation, double operationPrecision)
            {
                var doubleResult = doubleOperation(@double);
                var bigDoubleResult = bigDoubleOperation(bigDouble);
                Tests.AssertEqual(bigDoubleResult, doubleResult, operationPrecision, name);
            }
        }

        public class BinaryTestCase
        {
            private readonly (double first, double second) doubles;
            private readonly (BigDouble first, BigDouble second) bigDoubles;
            private readonly double precision;
            private readonly string name;

            public BinaryTestCase(string name, double first, double second, double precision = BigDouble.Tolerance)
            {
                this.name = name;
                doubles = (first, second);
                bigDoubles = (first, second);
                this.precision = precision;
            }

            public void AssertEqual(Func<double, double, double> doubleOperation,
                Func<BigDouble, BigDouble, BigDouble> bigDoubleOperation)
            {
                var doubleResult = doubleOperation(doubles.first, doubles.second);
                var bigDoubleResult = bigDoubleOperation(bigDoubles.first, bigDoubles.second);
                Tests.AssertEqual(bigDoubleResult, doubleResult, precision, name);
            }

            public void AssertComparison(Func<double, double, bool> doubleOperation,
                Func<BigDouble, BigDouble, bool> bigDoubleOperation)
            {
                var doubleResult = doubleOperation(doubles.first, doubles.second);
                var bigDoubleResult = bigDoubleOperation(bigDoubles.first, bigDoubles.second);
                Assert.AreEqual(doubleResult, bigDoubleResult,
                    $"Double implementation: {doubleResult}, BigDouble implementation: {bigDoubleResult}");
            }
        }
    }
}
