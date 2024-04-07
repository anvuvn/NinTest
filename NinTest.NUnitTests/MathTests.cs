using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NinTest.Basic;

namespace NinTest.NUnitTests
{
    
    [TestFixture]
    public class MathTests
    {
        private Basic.Math _math;
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Call the setup method");
            _math = new Basic.Math(); 
        }

        // Parameterize
        [Test]
        [TestCase(1, 2, 2)]
        [TestCase(3, 1, 3)]
        [TestCase(2, 2, 2)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult) 
        {
            //Act 
            var result = _math.Max(a, b);  
        
            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }


        [Test]
        public void Add_WhenCalled_ReturnSumOfArguments() 
        {    
            //Act
            var result = _math.Add(1, 2);

            //Assert
            Assert.That(result, Is.EqualTo(3));         
        }


        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            // Act
            var result  = _math.GetOddNumbers(5);

            // Assert
            Assert.That(result, Is.EquivalentTo(new[] { 1,3,5 }));

            // Others assertion                              
            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Unique);
        }
    }
}
