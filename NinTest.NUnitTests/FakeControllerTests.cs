using NinTest.Basic;

namespace NinTest.NUnitTests
{
    [TestFixture]
    public class FakeControllerTests
    {
        [Test]
        public void GetItem_IdIsLEZero_ReturnNotFound()
        {
            var controller = new FakeController();
            var result = controller.GetItem(0);

            // Specific type of object
            Assert.That(result, Is.TypeOf<NotFound>());

            // Object could be the type of its derivatives                                       
            Assert.That(result, Is.InstanceOf<NotFound>());
        }


        [Test]
        public void GetItem_IdIsGEZero_ReturnOk()
        {
            var controller = new FakeController();
            var result = controller.GetItem(1);

            // Specific type of object
            Assert.That(result, Is.TypeOf<Ok>());

            // Object could be the type of its derivatives                                       
            Assert.That(result, Is.InstanceOf<Ok>());
        }
    }
}