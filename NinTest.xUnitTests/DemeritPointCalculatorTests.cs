using NinTest.Basic;

namespace NinTest.xUnitTests
{
     
    public class DemeritPointCalculatorTests
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(301)]
        public void DemeritPointCalculator_SpeedIsOutOfRange_ThrowArgumentOutOfRangeException(int speed)
        {
            //Arrange
            var demeritCal = new DemeritPointCalculator();

            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => demeritCal.CalculateDemeritPoint(speed));
        }


        [Theory]
        [InlineData(0, 0)]
        [InlineData(60, 0)]
        [InlineData(65, 0)]
        [InlineData(66, 0)]
        [InlineData(70, 1)]
        [InlineData(75, 2)]
        public void DemeritPointCalculator_SpeedIsLessOrEqualSpeedLimit_ReturnZero(int speed, int demeritPoint)
        {
            //Arrange
            var demeritCal = new DemeritPointCalculator();
            //Act
            var result = demeritCal.CalculateDemeritPoint(speed);
            //Assert
            Assert.Equal(demeritPoint, result);
        }
    }
}