using NinTest.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NinTest.NUnitTests
{
    [TestFixture]
    public class DemeritPointCalculatorTests
    {  
        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void DemeritPointCalculator_SpeedIsOutOfRange_ThrowArgumentOutOfRangeException(int speed)
        {
            //Arrange
            var demeritCal = new DemeritPointCalculator();

            //Assert
            Assert.That(() => demeritCal.CalculateDemeritPoint(speed), Throws.TypeOf<ArgumentOutOfRangeException>()); 
        }


        [Test ]                                     
        [TestCase(0, 0)]
        [TestCase(60, 0)]
        [TestCase(65, 0)]
        [TestCase(66, 0)]
        [TestCase(70, 1)]
        [TestCase(75, 2)] 
        public void DemeritPointCalculator_SpeedIsLessOrEqualSpeedLimit_ReturnZero(int speed, int demeritPoint)
        {
            //Arrange
            var demeritCal = new DemeritPointCalculator();
            //Act
            var result = demeritCal.CalculateDemeritPoint(speed);
            //Assert
            Assert.That(result, Is.EqualTo(demeritPoint));
        }
    }
}                                             