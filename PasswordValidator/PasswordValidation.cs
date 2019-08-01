using PasswordValidator.Extensions;

namespace PasswordValidator
{
    public class PasswordValidation
    {
        public bool IsValid(string input, int minimalLength)
            => input.IsNotNullOrEmpty()
               && input.ContainsCapitalLetter()
               && input.ContainsLowercaseLetter()
               && input.IsLongerThanEightCharacter(minimalLength);

    }

}