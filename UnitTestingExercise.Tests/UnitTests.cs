using System;
using System.Runtime.CompilerServices;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(10, 20, 30, 60)]
        [InlineData(11, 81, 15, 107)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calculator = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = calculator.Add(num1, num2, num3);

            //Assert
            //Assert.Equal(expected, actual);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(18, 9, 9)]  //Add test data <-------
        [InlineData(10, 20, -10)]
        [InlineData(50, 70, -20)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calculator = new Calculator();
            //Act
            var actual = calculator.Subtract(minuend, subtrahend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 5, 25)]//Add test data <-------
        [InlineData(10, 10, 100)]
        [InlineData(7, 8, 56)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:
            //Arrange
            var calculator = new Calculator();
            //Act
            var actual = calculator.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(9, 3, 3)]
        [InlineData(25, 5, 5)]
        [InlineData(100, 10, 10)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calculator = new Calculator();
            //Act
            var actual = calculator.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);



        }
    }
}
