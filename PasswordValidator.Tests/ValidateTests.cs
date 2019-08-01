using Xunit;

namespace PasswordValidator.Tests
{
    public class ValidateTests
    {
        private readonly PasswordValidation _validator;

        public ValidateTests()
        {
            _validator = new PasswordValidation();
        }

        [Fact]
        private void EmptyStringShouldReturnFalse()
            => Assert.False(_validator.IsValid("",5));

        [Fact]
        private void NullStringShouldReturnFalse()
            => Assert.False(_validator.IsValid(null,5));

        [Fact]
        private void AtLeastOneCapitalLetterShouldReturnTrue()
            => Assert.True(_validator.IsValid("Abcabc12",5));

        [Fact]
        private void NoCapitalLetterShouldReturnFalse()
            => Assert.False(_validator.IsValid("abcabc12",5));

        [Fact]
        private void AtLeastOneLowerCaseLetterShouldReturnTrue()
            => Assert.True(_validator.IsValid("ABCDe12",5));

        [Fact]
        private void NoLowerCaseLetterShouldReturnFalse()
            => Assert.False(_validator.IsValid("ABCDEF12",5));

        [Fact]
        private void AtLeastOneDigitShouldReturnTrue()
            => Assert.True(_validator.IsValid("ABCdef1",5));

        [Fact]
        private void NoOneDigitShouldReturnFalse()
            => Assert.True(_validator.IsValid("ABCdef",5));

        [Theory]
        [InlineData("ABCdef123", 8)]
        private void LongerLengthThanNumberShouldReturnTrue(string input, int number)
            => Assert.True(_validator.IsValid(input, number));

        [Theory]
        [InlineData("ABCdef1", 8)]
        private void ShorterLengthThanNumberShouldReturnFalse(string input, int number)
            => Assert.False(_validator.IsValid(input, number));
    }
}