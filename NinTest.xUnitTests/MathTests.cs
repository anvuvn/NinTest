using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinTest.xUnitTests
{
    public class MathTests : IDisposable
    {
        private Basic.Math _math;
        public MathTests()
        {
            Console.WriteLine("Call");
            _math = new Basic.Math();
        }


        public void Dispose()
        {
            // similar to tear down - do it in this method
            // throw new NotImplementedException();     
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(3, 1, 3)]
        [InlineData(2, 2, 2)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            //Act 
            var result = _math.Max(a, b);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Add_WhenCalled_ReturnSumOfArguments()
        {                  
            //Act
            var result = _math.Add(1, 2);

            //Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            // Act
            var result = _math.GetOddNumbers(5);

            // Assert
            Assert.Equivalent(new[] { 1, 3, 5 }, result); 
            
            // XUnit does not offer Ordered Assertion
            Assert.Distinct(result);
        }
    }
}
