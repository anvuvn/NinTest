using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NinTest.Basic;

namespace NinTest.NUnitTests
{
    [TestFixture]
    public class FooBarTests
    {
        //private FooBar _fooBar;
     
        //[SetUp]
        //public void SetUp() {
        //    _fooBar = new FooBar();
        //}

        [Test]
        public void GetFooBar_InputDivisibleBy2And3_ReturnFooBar()
        {
            var result = FooBar.GetFooBar(6);
            //
            Assert.That(result, Is.EqualTo("FooBar"));
        }


        [Test]
        public void GetFooBar_InputDivisibleBy2Only_ReturnFoo()
        {
            var result = FooBar.GetFooBar(4);
            //
            Assert.That(result, Is.EqualTo("Foo"));
        }

        [Test]
        public void GetFooBar_InputDivisibleBy3Only_ReturnFoo()
        {
            var result = FooBar.GetFooBar(9);
            //
            Assert.That(result, Is.EqualTo("Bar"));
        }

        [Test]
        public void GetFooBar_InputIsNotDivisibleBy2Or3_ReturnNumber()
        {
            var result = FooBar.GetFooBar(11);
            //
            Assert.That(result, Is.EqualTo("11"));
        }   
    }
}
