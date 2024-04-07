using NinTest.Basic;

namespace NinTest.xUnitTests
{
     
    public class LoggerTests
    {
        [Fact]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            // Arrage
            var logger = new Logger();

            //Act 
            logger.Log("Message");

            // Assert
            Assert.Equal("Message", logger.LastError);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string message)
        {
            // Arrage
            var logger = new Logger();

            //Act - Assert                                                       
            Assert.Throws<ArgumentNullException>(() => logger.Log(message));
        }

        [Fact]
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
            Assert.NotEqual(id, Guid.Empty);

        }
    }
}