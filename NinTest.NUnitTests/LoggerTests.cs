using NinTest.Basic;

namespace NinTest.NUnitTests
{
    [TestFixture]
    public class LoggerTests
    {
        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            // Arrage
            var logger = new Logger();

            //Act 
            logger.Log("Message");

            // Assert
            Assert.That(logger.LastError, Is.EqualTo("Message"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string? message)
        {                    
            // Arrage
            var logger = new Logger();

            //Act - Assert                                                       
            Assert.That(() => logger.Log(message), Throws.ArgumentNullException);  
        }

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            var logger = new Logger();
            //
            var id = Guid.Empty;
            logger.ErrorLogged += (sender, args) => {
                id = args;
            };
            logger.Log("message");
            //
            Assert.That(id, Is.Not.EqualTo(Guid.Empty));

        }
    }
}