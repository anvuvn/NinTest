using NinTest.Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinTest.xUnitTests
{
    public class FunStackTests
    {
        // Pop
        // - Empty stack:  throw invalid operation
        [Fact]
        public void Pop_FunStackIsEmpty_ThrowsInvalidOperationException()
        {
            var stack = new FunStack<string>();
            Assert.Throws<InvalidOperationException>(() => stack.Pop() );
        }

        // - Stack with few objects ->  
        [Fact]
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
            Assert.Equal("Third", result);
        }

        [Fact]
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
            Assert.Equal(2, stack.Count);
        }

        //Peek
        // - Empty stack -> throw exception
        // - FunStack with elements -> return top object
        // - Peek not change element count       
        [Fact]
        public void Peek_FunStackIsEmpty_ThrowsInvalidOperationException()
        {
            var stack = new FunStack<string>();
            Assert.Throws<InvalidOperationException>(() => stack.Peek());
        }

        // - Stack with few objects ->  
        [Fact]
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
            Assert.Equal("Third", result);
        }

        [Fact]
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
            Assert.Equal(3, stack.Count);
        }

        //// Push            
        // - Object is null -> throws exception
        [Fact]
        public void Push_ArgIsNull_ThrowArgNullException()
        {
            var stack = new FunStack<string>();
            Assert.Throws<ArgumentNullException>(() => stack.Push(null));
        }

        // - Valid object -> ensure it put to the first object                                           
        [Fact]
        public void Push_ArgIsValid_AddObjectToTheStack()
        {
            var stack = new FunStack<string>();
            //
            stack.Push("first");
            // Assert the qualtity
            Assert.Equal(1, stack.Count);
        }

        // - Test empty stack has 0 element
        [Fact]
        public void Count_EmptyStack_EqualZero()
        {
            var stack = new FunStack<string>();
            //
            Assert.Equal(0, stack.Count); 
        }
    }
}
