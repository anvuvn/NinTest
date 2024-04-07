using NinTest.Basic;

namespace NinTest.xUnitTests
{
     
    public class xReservationTests
    {
        [Fact]
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void CanBeCancelledBy_CreatorCancelling_ReturnTrue()
        {
            // Arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user };

            //Act
            var result = reservation.CanBeCancelledBy(user);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void CanBeCancelledBy_OtherUserCancelReservation_ReturnFalse()
        {
            // Arrange
            var reservation = new Reservation { MadeBy = new User { } };

            //Act
            var result = reservation.CanBeCancelledBy(new User { });

            //Assert
            Assert.False(result);
        }
    }
}