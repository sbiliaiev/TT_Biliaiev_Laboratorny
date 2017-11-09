using System;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Lab_2;

namespace UnitTestProject1
{
    public class UnitTest1
    {
        /*[Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }*/

        /*[Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]

        public void MyFirstTheory(int value)
        {
            Assert.True(IsOdd(value));
        }*/

        /*bool IsOdd(int value)
        {
            return value % 2 == 1;
        }

        int Add(int x, int y)
        {
            return x + y;
        }

        void ThrowingMethod()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public async void CodeThrowsAsync()
        {
            Func<Task> testCode = () => Task.Factory.StartNew(ThrowingMethod);
            var ex = await Assert.ThrowsAsync<NotImplementedException>(testCode);
            Assert.IsType<NotImplementedException>(ex);
        }*/

        /// <summary>
        /// Variant 3
        /// </summary>
        [Fact]
        public void ReturnFalseGivenValueOf1()
        {
            PrimeService ps = new PrimeService();
            var result = ps.IsPrime(1);
            var result1 = ps.IsPrime(11);
            var result2 = ps.IsPrime(12);

            Assert.False(result, $"1 should not be prime");
            Assert.True(result1, $"1 should be prime");
            Assert.False(result2, $"1 should not be prime");
        }

        /// <summary>
        /// Variant 5
        /// </summary>
        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(6)]
        public void TestIsOdd(int value)
        {
            Assert.True(Number.IsOdd(value));
        }
    }
}
