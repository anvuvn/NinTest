using NinTest.Basic;

namespace NinTest.xUnitTests
{
     
    public class FooBarTests
    {
        [Fact]
        public void GetFooBar_InputDivisibleBy2And3_ReturnFooBar()
        {
            var result = FooBar.GetFooBar(12);
            //
            Assert.Equal("FooBar", result);
        }


        [Fact]
        public void GetFooBar_InputDivisibleBy2Only_ReturnFoo()
        {
            var result = FooBar.GetFooBar(4);
            //                         
            Assert.Equal("Foo", result);
        }

        [Fact]
        public void GetFooBar_InputDivisibleBy3Only_ReturnFoo()
        {
            var result = FooBar.GetFooBar(9);
            //
            Assert.Equal("Bar", result);
        }

        [Fact]
        public void GetFooBar_InputIsNotDivisibleBy2Or3_ReturnNumber()
        {
            var result = FooBar.GetFooBar(11);
            //
            Assert.Equal("11", result);
        }
    }
}