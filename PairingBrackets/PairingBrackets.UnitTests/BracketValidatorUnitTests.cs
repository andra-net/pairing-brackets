using Xunit;

namespace PairingBrackets.UnitTests
{
    public class BracketValidatorUnitTests
    {
        private readonly BracketValidator sut;

        public BracketValidatorUnitTests()
        {
            sut = new BracketValidator();
        }

        [Theory]
        [InlineData("", true)]
        [InlineData("{}", true)]
        [InlineData("{([])}", true)]
        [InlineData("{([(({[]}))])}", true)]
        [InlineData("([{()}])()", true)]
        [InlineData("{]", false)]
        [InlineData("{[]", false)]
        [InlineData(")", false)]
        [InlineData(")(", false)]
        [InlineData("(/_()", false)]
        [InlineData("([{()}]))", false)]
        [InlineData("([{()}])(", false)]
        [InlineData("123", false)]
        public void Validate_GivenTheInput_ReturnExpectedResult(string input, bool expectedResult)
        {
            // Act
            var result = sut.Validate(input);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
