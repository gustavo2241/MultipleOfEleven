using MultipleOfEleven.Domain.Models;
using MultipleOfEleven.Domain.Services.Multiple;
using Xunit;

namespace MultipleOfEleven.Tests
{
    public class IsMultipleUnitTest
    {
        [Fact(DisplayName = "Validando se um numero multiplo de 11 é multiplo de 11")]
        public void Validate_ValidateIfMultipleOfEleven_ReturnTrue()
        {
            //arrange
            string[] numbersArray = { "112233" };
            var numbers = new Numbers(numbersArray);

            //act
            var multipleService = new MultipleService();
            var isMultiple = multipleService.IsMultiple(numbers);


            foreach (var number in isMultiple.result)
            {
                //assert
                Assert.True(number.isMultiple);
            }

        }

        [Fact(DisplayName = "Validando se um numero não multiplo de 11 é multiplo de 11")]
        public void Validate_ValidateIfMultipleOfEleven_ReturnFalse()
        {
            //arrange
            string[] numbersArray = { "112234" };
            var numbers = new Numbers(numbersArray);

            //act
            var multipleService = new MultipleService();
            var isMultiple = multipleService.IsMultiple(numbers);


            foreach (var number in isMultiple.result)
            {
                //assert
                Assert.False(number.isMultiple);
            }

        }
    }
}