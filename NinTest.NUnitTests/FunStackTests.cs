using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NinTest.Basic;

namespace NinTest.NUnitTests
{
    [TestFixture]
    public class FunStackTests
    {
        // Pop
        // - Empty stack:  throw invalid operation
        [Test]
        public void Pop_FunStackIsEmpty_ThrowsInvalidOperationException()
        {
            var stack = new FunStack<string>();
            Assert.That(() => stack.Pop(), Throws.TypeOf<InvalidOperationException>());
        }

        // - Stack with few objects ->  
        [Test]
        public void Pop_FunStackWithFewObjects_ReturnTopObject()
        {
            //Arrange
            var stack = new FunStack<string>();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");

            //Act
            var result = stack.Pop();

            //Assert 
            Assert.That(result, Is.EqualTo("Third"));
        }

        [Test]
        public void Pop_FunStackWithFewObjects_RemoveTopObject()
        {
            //Arrange
            var stack = new FunStack<string>();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");

            //Act
            stack.Pop();

            //Assert 
            Assert.That(stack.Count, Is.EqualTo(2));
        }

        //Peek
        // - Empty stack -> throw exception
        // - FunStack with elements -> return top object
        // - Peek not change element count       
        [Test]
        public void Peek_FunStackIsEmpty_ThrowsInvalidOperationException()
        {
            var stack = new FunStack<string>();
            Assert.That(() => stack.Peek(), Throws.TypeOf<InvalidOperationException>());
        }

        // - Stack with few objects ->  
        [Test]
        public void Peek_FunStackWithFewObjects_ReturnTopObject()
        {
            //Arrange
            var stack = new FunStack<string>();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");

            //Act
            var result = stack.Peek();

            //Assert 
            Assert.That(result, Is.EqualTo("Third"));
        }

        [Test]
        public void Peek_FunStackWithFewObjects_RemoveTopObject()
        {
            //Arrange
            var stack = new FunStack<string>();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");

            //Act
            stack.Peek();

            //Assert 
            Assert.That(stack.Count, Is.EqualTo(3));
        }    

        //// Push            
        // - Object is null -> throws exception
        [Test]
        public void Push_ArgIsNull_ThrowArgNullException()
        {
            var stack = new FunStack<string>();
            Assert.That(() => stack.Push(null), Throws.TypeOf<ArgumentNullException>());
        }

        // - Valid object -> ensure it put to the first object                                           
        [Test]
        public void Push_ArgIsValid_AddObjectToTheStack()
        {
            var stack = new FunStack<string>();
            //
            stack.Push("first");
            // Assert the qualtity
            Assert.That(stack.Count, Is.EqualTo(1));
        }

        // - Test empty stack has 0 element
        [Test]
        public void Count_EmptyStack_EqualZero()
        {
            var stack = new FunStack<string>();    
            //
            Assert.That(stack.Count, Is.EqualTo(0));
        }
    }
}
