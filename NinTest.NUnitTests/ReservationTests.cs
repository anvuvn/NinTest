using NinTest.Basic;

namespace NinTest.NUnitTests
{
    [TestFixture]
    public class ReservationTests
    {
        [Test] 
        public void CanBeCancelledBy_AdminCancelling_ReturnsTrue()
        {
            // Arrange
            var reservation = new Reservation();

            // Act
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanBeCancelledBy_CreatorCancelling_ReturnTrue()
        {
            // Arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user };

            //Act
            var result = reservation.CanBeCancelledBy(user);

            //Assert
            Assert.That(result, Is.True);
            //Assert.That(result == true);
            //Assert.True(result);
        }

        [Test]
        public void CanBeCancelledBy_OtherUserCancelReservation_ReturnFalse()
        {
            // Arrange
            var reservation = new Reservation{MadeBy = new User { } };

            //Act
            var result = reservation.CanBeCancelledBy(new User { });

            //Assert
            Assert.That(result, Is.False); 
        }

    }
}