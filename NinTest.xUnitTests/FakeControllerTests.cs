using NinTest.Basic;

namespace NinTest.xUnitTests
{
     
    public class FakeControllerTests
    {
        [Fact]
        public void GetItem_IdIsLEZero_ReturnNotFound()
        {
            var controller = new FakeController();
            var result = controller.GetItem(0);

            // Specific type of object     
            Assert.IsType<NotFound>(result); 
        }


        [Fact]
        public void GetItem_IdIsGEZero_ReturnOk()
        {
            var controller = new FakeController();
            var result = controller.GetItem(1);

            // Specific type of object
            Assert.IsType<Ok>(result); 
        }
    }
}