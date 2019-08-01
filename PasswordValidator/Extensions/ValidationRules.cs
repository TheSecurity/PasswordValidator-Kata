using System.Linq;

namespace PasswordValidator.Extensions
{
    public static class Extensions
    {
        public static bool IsNotNullOrEmpty(this string input) => !string.IsNullOrEmpty(input);
        public static bool ContainsCapitalLetter(this string input) => !input.ToLower().Equals(input);
        public static bool ContainsLowercaseLetter(this string input) => !input.ToUpper().Equals(input);
        public static bool ContainsOneNumber(this string input) => input.Any(char.IsDigit);
        public static bool IsLongerThanEightCharacter(this string input, int number) => input.Length > number;
    }
}