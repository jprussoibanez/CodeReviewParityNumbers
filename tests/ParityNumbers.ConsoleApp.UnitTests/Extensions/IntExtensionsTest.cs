using Xunit;
using ParityNumbers.ConsoleApp.Extensions;
using FluentAssertions;
using ParityNumbers.ConsoleApp.Models;

namespace ParityNumbers.ConsoleApp.UnitTests
{
    public class IntExtensionsTest
    {
        #region Get parity tests

        [Fact(DisplayName = "Get parity for positive even number")]
        public void GetParityPositiveEvenNumber()
        {
            //Arrange
            int number = 2;

            //Act
            var parity = number.GetParity();

            //Assert
            parity.ShouldBeEquivalentTo(Parity.Even);
        }

        [Fact(DisplayName = "Get parity for positive odd number")]
        public void GetParityPositiveOddNumber()
        {
            //Arrange
            int number = 1;

            //Act
            var parity = number.GetParity();

            //Assert
            parity.ShouldBeEquivalentTo(Parity.Odd);
        }

        [Fact(DisplayName = "Get parity for zero number")]
        public void GetParityPositiveZeroNumber()
        {
            //Arrange
            int number = 0;

            //Act
            var parity = number.GetParity();

            //Assert
            parity.ShouldBeEquivalentTo(Parity.Even);
        }

        [Fact(DisplayName = "Get parity for negative even number")]
        public void GetParityNegativeEvenNumber()
        {
            //Arrange
            int number = -4;

            //Act
            var parity = number.GetParity();

            //Assert
            parity.ShouldBeEquivalentTo(Parity.Even);
        }

        [Fact(DisplayName = "Get parity for negative odd number")]
        public void GetParityNegativeOddNumber()
        {
            //Arrange
            int number = -7;

            //Act
            var parity = number.GetParity();

            //Assert
            parity.ShouldBeEquivalentTo(Parity.Odd);
        }
        #endregion

        #region Get parity text tests
        [Fact(DisplayName = "Get parity text for even number")]
        public void GetParityTextEvenNumber()
        {
            //Arrange
            int number = 2;

            //Act
            var parityText = number.GetParityText();

            //Assert
            parityText.ShouldBeEquivalentTo("is even");
        }

        [Fact(DisplayName = "Get parity text for odd number")]
        public void GetParityTextOddNumber()
        {
            //Arrange
            int number = 1;

            //Act
            var parityText = number.GetParityText();

            //Assert
            parityText.ShouldBeEquivalentTo("is odd");
        }
        #endregion
    }
}
