using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDrivenDevelopment;
using Xunit;

namespace TestDrivenDevelopment.Tests
{
    public class ValidatorTests
    {
        [Fact]
        public void IsPinValid_True()
        {
            // Arrange
            bool expected = true;


            // Act
            bool actual = Validator.IsPinValid(2254, 2254);
            
            // Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void IsPinValid_False()
        {
            // Arrange
            bool expected = false;


            // Act
            bool actual = Validator.IsPinValid(2254, 2255);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("1264512369874589")]
        public void IsCardNumberLengthValid_True(string insertedCardNumber)
        {
            // Arrange
            bool expected = true;

            // Act
            bool actual = Validator.IsCardNumberLengthValid(insertedCardNumber);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("126451236987458")]
        public void IsCardNumberLengthValid_False(string insertedCardNumber)
        {
            // Arrange
            bool expected = false;

            // Act
            bool actual = Validator.IsCardNumberLengthValid(insertedCardNumber);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
